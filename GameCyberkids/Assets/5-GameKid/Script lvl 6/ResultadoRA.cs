using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultadoRA : MonoBehaviour
{ 
    public Text cantidadAtaquesA;
    
    void Start()
    {
        cantidadAtaquesA = GetComponent<Text>();
    }

    void Update()
    {         
        cantidadAtaquesA.text = "" + PosiciónInstancia.countRansom;

    }
}