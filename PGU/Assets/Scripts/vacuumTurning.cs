using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vacuumTurning : MonoBehaviour
{
    public GameObject vaccum;
    public void enable()
    {
        if (vaccum.active)
            vaccum.SetActive(false);
        else
            vaccum.SetActive(true);
    }
}
