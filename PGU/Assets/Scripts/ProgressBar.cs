using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;
    public Text progressText;
    public float gameTime;
    public float currentTime;
    public float progressValue;
    public Material material;
    private bool blinkSet;
    public float ProgressValue
    {
        get { return progressValue; }
        set
        {
            progressValue = value;
            slider.value = progressValue;
            string progressString = (progressValue * 100).ToString("0.##") + "%";
            progressText.text = progressString;
            blinkSet = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        ProgressValue = 0f;
        currentTime = 0f;
        material.SetFloat("_Blink", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (ProgressValue < 1)
        {
            currentTime += Time.deltaTime;
            ProgressValue = currentTime / (gameTime * 60);
        } else
        {
            ProgressValue = 1;
        }
        if(blinkSet == false && ProgressValue > 0.75f)
        {
            material.SetFloat("_Blink", 1);
            blinkSet = true;
        }
    }

    public void delayConstruction()
    {
        currentTime = currentTime * 0.9f;
    }
}
