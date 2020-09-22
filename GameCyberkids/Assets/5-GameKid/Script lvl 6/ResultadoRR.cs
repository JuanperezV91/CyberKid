using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultadoRR : MonoBehaviour
{
   public Text cantidadAtaquesR;
    
    void Start()
    {      
        cantidadAtaquesR = GetComponent<Text>();               
    }

    void Update()
    {    
        cantidadAtaquesR.text = "" + PosicionInstanciaRed.countPubli;      
    }
}