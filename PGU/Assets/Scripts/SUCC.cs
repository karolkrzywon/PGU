using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SUCC : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("CollisionEnter \"" + other.gameObject.name + " \"Object");
        if (other.gameObject.name == "Dwarf"){
            Destroy(other.gameObject);
        }
    }
}
