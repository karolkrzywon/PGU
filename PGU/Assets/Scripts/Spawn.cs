using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;

public class Spawn : MonoBehaviour
{
    int interval = 10;
    float nextTime = 0;
    public GameObject dwarf;
    int x = 0;
    int y = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextTime)
        {
            x = Random.Range(200, 500);
            y = Random.Range(100, 300);
            dwarf.transform.position = new Vector3(x, y, 0); 
            nextTime += interval;
        }
    }
}
