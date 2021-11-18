using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public float progressValue;
    public int killCount;

    public GameData (float progressValue, int killCount)
    {
        this.progressValue = progressValue;
        this.killCount = killCount;
    }
}