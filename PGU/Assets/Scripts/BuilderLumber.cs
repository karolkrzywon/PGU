using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderLumber : MonoBehaviour
{
    public ParticleSystem buildingParticle;
    public GameObject builder;
    public void stand()
    {
        builder.GetComponent<Animator>().enabled = false;
        buildingParticle.Stop();
    }
}
