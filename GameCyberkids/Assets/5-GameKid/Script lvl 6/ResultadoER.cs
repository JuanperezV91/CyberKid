using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultadoER : MonoBehaviour
{
    public Text cantidadEscudosR;
 
    void Start()
    {
        cantidadEscudosR = GetComponent<Text>();
    }

    void Update()
    {
     
        cantidadEscudosR.text = "" + PosicionInstanciaRed.countBloqueos;

    }
}