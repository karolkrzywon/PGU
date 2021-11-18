using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UI;


public class SaveGame : MonoBehaviour
{
    public Slider progressBar;
    public GameObject controlObject;
    public void SaveState()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gameData";
        FileStream stream = new FileStream(path, FileMode.Create);
        int killCount = controlObject.GetComponent<GameController>().killCount;
        GameData gameData = new GameData(progressBar.value, killCount);
        formatter.Serialize(stream, gameData);
        stream.Close();
    }
    /*
    public void loadData()
    {
        string path = Application.persistentDataPath + "/gameData";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            GameData gameData = formatter.Deserialize(stream) as GameData;
            stream.Close();

            progressBar.value = gameData.progressValue;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
        }
    }*/
}
