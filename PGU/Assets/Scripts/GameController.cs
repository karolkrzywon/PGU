using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int killCount = 0;
    public Slider slider;
    public GameObject jumpingDwarf;
    public GameObject walkingDwarf1;
    public GameObject walkingDwarf2;
    public GameObject spawningDwarf;
    public GameObject vaccum;
    public GameObject cylinder;
    public GameObject material;
    public GameObject[] soldiers;
    public GameObject light;

    private void Start()
    {
        jumpingDwarf.SetActive(false);
    }
    void Update()
    {
        if (killCount == 5)
        {
            callSoldiers();
        }
        if (slider.value == 1)
        {
            jumpProcedure();
        }
    }
    public void succDwarf()
    {
        killCount++;
        delayConstruction();
    }

    private void delayConstruction()
    {
        slider.GetComponent<ProgressBar>().delayConstruction();
    }

    private void callSoldiers()
    {
        foreach (GameObject soldier in soldiers)
        {
            soldier.SetActive(true);
        }
        vaccum.SetActive(false);
        cylinder.SetActive(false);
        light.GetComponent<Light>().color = Color.red;
    }

    private void jumpProcedure()
    {
        jumpingDwarf.SetActive(true);
        walkingDwarf1.GetComponent<BuilderWalk>().stand();
        walkingDwarf1.transform.position = new Vector3(270, 150, 150);
        walkingDwarf1.transform.rotation = Quaternion.Euler(0, 180, 0);
        walkingDwarf2.GetComponent<BuilderLumber>().stand();
        walkingDwarf2.transform.position = new Vector3(235, 150, 150);
        walkingDwarf2.transform.rotation = Quaternion.Euler(0, 180, 0);
        spawningDwarf.SetActive(false);
        vaccum.SetActive(false);
        cylinder.SetActive(false);
        material.SetActive(false);
        foreach (GameObject soldier in soldiers)
        {
            soldier.SetActive(false);
        }
        light.GetComponent<Light>().color = Color.white;
    }
}
