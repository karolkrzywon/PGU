using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;

public class Spawn : MonoBehaviour
{
    int interval = 2;
    float nextTime = 0;
    private GameObject dwarf;
    int x = 0;
    int y = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        dwarf = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextTime)
        {
            x = Random.Range(-12, 13);
            y = Random.Range(-6, 6);
            dwarf.transform.position = new Vector3(x, y, 0); 
            nextTime += interval;
        }
    }
}
