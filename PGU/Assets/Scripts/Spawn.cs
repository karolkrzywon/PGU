using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;

public class Spawn : MonoBehaviour
{
    int interval = 10;
    float nextTime = 0;
    public GameObject dwarf;
    public GameObject crown;
    int x = 0;
    int z = 0;
    private Material material;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<MeshRenderer>().sharedMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextTime)
        {
            changePosition();
            nextTime += interval;
        }
    }

    public void changePosition()
    {
        int dwarfNumber = Random.Range(0, 3);
        if (dwarfNumber == 1)
        {
            crown.SetActive(true);
            material.SetFloat("_CX", 3);
        }
        else
        {
            crown.SetActive(false);
            material.SetFloat("_CX", 1);
        }   
        x = Random.Range(170, 535);
        z = Random.Range(50, 200);
        dwarf.transform.position = new Vector3(x, 150, z);
    }
}
