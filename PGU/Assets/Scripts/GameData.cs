using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public float progressValue;
    public GameData (ProgressBar progressBar)
    {
        progressValue = progressBar.progressValue;
    }
}
