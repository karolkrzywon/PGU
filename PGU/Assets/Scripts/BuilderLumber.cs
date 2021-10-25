using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderLumber : MonoBehaviour
{
    public GameObject builder;
    public void stand()
    {
        builder.GetComponent<Animator>().enabled = false;
    }
}
