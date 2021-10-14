using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickOnObject : MonoBehaviour {
    public Camera camera;
    public Text txt;
    void Start(){

    }
    void Update(){
        if (Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) {
                Transform objectHit = hit.transform;
                txt.text = objectHit.name;
                // Do something with the object that was hit by the raycast.
            }
        }
    }
}
