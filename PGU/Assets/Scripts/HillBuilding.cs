using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HillBuilding : MonoBehaviour
{
    public GameObject[] hillList;
    public Slider slider;
    public GameObject slopeObject;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject hill in hillList)
        {
            hill.SetActive(false);
        }
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        double sliderValue = slider.value;
        if (sliderValue <= 0.975)
        {
            double progress = sliderValue / 7.5 * 100;
            for (int i = 0; i < progress; i++)
            {
                if (hillList[i] && !hillList[i].active)
                {
                    hillList[i].SetActive(true);
                }
            }
        } 
    }
}
