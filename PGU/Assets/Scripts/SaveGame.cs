using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class SaveGame
{
    public static void SaveState(ProgressBar progressBar)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gameData";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData gameData = new GameData(progressBar);

        formatter.Serialize(stream, gameData);
        stream.Close();
    }

    public static GameData loadData()
    {
        string path = Application.persistentDataPath + "/gameData";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            GameData gameData = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return gameData;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
