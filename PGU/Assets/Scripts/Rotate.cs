using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotate : MonoBehaviour
{
    public GameObject cone;
    public float RotationSpeed = 5;
     // Update is called once per frame
    void Update ()
    {
         transform.Rotate((Input.GetAxis("Mouse Y") * RotationSpeed * (-10) * Time.deltaTime), (Input.GetAxis("Mouse X") * 10 * RotationSpeed * Time.deltaTime), 0, Space.World);
    }
    // void OnCollisionEnter(Collision other)
    // {
    //     Debug.Log("CollisionEnter \"" + other.gameObject.name + " \"Object");
    // }
}