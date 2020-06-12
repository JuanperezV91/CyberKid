using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class CyberSaveSystem : MonoBehaviour
{
   public static void SavePlayer (CyberPlayer player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "\\player.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        CyberPlayerData data = new CyberPlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static CyberPlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "\\player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            CyberPlayerData data = formatter.Deserialize(stream) as CyberPlayerData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Fila no encontrada" + path);
            return null;
        }
    }
}
