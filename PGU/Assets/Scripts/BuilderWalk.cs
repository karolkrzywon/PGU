using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderWalk : MonoBehaviour
{
    public bool movingDirection = true; //true - right, false - left
    public GameObject builder;
    public float currentTime;
    public GameObject materialPart;
    private bool disableWalk;

    // Update is called once per frame
    void Update()
    {
        if (!disableWalk)
        {
            if (movingDirection == true && builder.transform.position.x < 500)
            {
                builder.transform.position = builder.transform.position + new Vector3(50 * (Time.deltaTime), 0, 0);
                materialPart.SetActive(true);
            }
            else if (movingDirection == true && builder.transform.position.x >= 500)
            {
                movingDirection = false;
                builder.transform.rotation = Quaternion.Euler(0, -90, 0);
            }
            else if (movingDirection == false && builder.transform.position.x > 220)
            {
                builder.transform.position = builder.transform.position + new Vector3(-50 * (Time.deltaTime), 0, 0);
                materialPart.SetActive(false);
            }
            else if (movingDirection == false && builder.transform.position.x <= 220)
            {
                movingDirection = true;
                builder.transform.rotation = Quaternion.Euler(0, 90, 0);
            }
        }
    }

    public void stand()
    {
        disableWalk = true;
        builder.GetComponent<Animator>().enabled = false;
    }
}
