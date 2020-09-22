using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultadoEV : MonoBehaviour
{
    //Score 
    public Text cantidadEscudosV;
  
    void Start()
    {
        cantidadEscudosV = GetComponent<Text>();
    }

    void Update()
    {             
      cantidadEscudosV.text = "" + PosiciónInstancia.countBloqueos;
    }
}