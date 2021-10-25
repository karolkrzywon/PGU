using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public Vector3 startPostion;
    public Vector3 slopeTreshHold;
    public Vector3 curvePointUp;
    public Vector3 maxHeight;
    public Vector3 curvePointDown;
    public Vector3 landingPosition;
    public GameObject jumper;
    private int state;
    private bool updateOn;

    // Start is called before the first frame update
    void Start()
    {
        state = 6;
        updateOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (updateOn)
        {
            Vector3 destination = getCurrentDestination();
            Vector3 direction = getDirection(destination);
            jumper.transform.position += direction;
            updateState(direction);
        }
    }

    private Vector3 getDirection(Vector3 destination)
    {
        return (destination - jumper.transform.position).normalized;
    }
    
    private Vector3 getCurrentDestination()
    {
        Vector3 destination = new Vector3(0,0,0);
        switch (state)
        {
            case 0:
                destination = slopeTreshHold;
                break;
            case 1:
                destination = curvePointUp;
                break;
            case 2:
                destination = maxHeight;
                break;
            case 3:
                destination = curvePointDown;
                break;
            case 4:
                destination = landingPosition;
                break;
            case 5:
                destination = startPostion;
                break;
            case 6:
                destination = slopeTreshHold;
                break;
        }
        return destination;
    }

    private void updateState(Vector3 destination)
    {
        if (ifReachedDestination(destination))
        {
            if (state == 5)
            {
                StartCoroutine(jumperChange());
                state = 0;
            }
            else if (state == 6)
                state = 1;
            else
                state++;
        }
    }

    private bool ifReachedDestination(Vector3 direction)
    {
        if (direction.x >= 0)
            return true;
        return false;
    }
    IEnumerator jumperChange()
    {
        updateOn = false;
        yield return new WaitForSeconds(1.0f);
        jumper.transform.position = startPostion;
        updateOn = true;
    }
}
