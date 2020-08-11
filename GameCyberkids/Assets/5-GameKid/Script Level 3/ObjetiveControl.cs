using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjetiveControl : MonoBehaviour
{

    public static int contTargets;  
    Text objetive;

    void Start()
    {
        objetive = GetComponent<Text>();
    }

    void Update()
    {
        objetive.text = "" + contTargets;
    }    
}
