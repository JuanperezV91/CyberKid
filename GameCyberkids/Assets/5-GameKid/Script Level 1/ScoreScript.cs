using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //Score 
    public static int scoreValue; //Variable estática la cual es invocada por las demas clases, para sumar puntaje
    Text score;
    
    //Este script debe ir en cada escenario u objeto dentro de cada escenario
    void Start() //Al comenzar cada escenario, los valores se cargan
    {
        score = GetComponent<Text>();

        //PlayerPrefs.GetInt("valor", variable estatica); Aquí obtenemos en todo momento el valor guardado

        scoreValue = PlayerPrefs.GetInt("value", scoreValue);
    }

    void Update()
    {
        score.text = "" + scoreValue;


        PlayerPrefs.SetInt("value", scoreValue); //Guardamos el valor numérico en una variable int
    }
}
