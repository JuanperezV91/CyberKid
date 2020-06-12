using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Manejar entradas y salidas en los ficheros
using System.IO;

public class SaveDataJson : MonoBehaviour
{
    /*
    string filePath;
    string jsonString;
    //Es llamado durante la carga del script, en lugar de cuando empieza el juego, entonces aquí se cargan datos masivos dentro de la memoria
    void Awake()
    {
        //Cargamos contenidos del fichero
        //Generamos ruta de directorio para nuestro personaje avatar
        filePath = Application.dataPath + "/Personaje.json";
        jsonString = File.ReadAllText(filepath);
        Personaje personajeKid = JsonUtility.FromJson<Personaje>(jsonString);
        print(personajeKid);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Serializable]
    public class Personaje
    {

        public override string ToString()
        {
            return string.Format("[Personaje]");
        }
    }
    */
}
