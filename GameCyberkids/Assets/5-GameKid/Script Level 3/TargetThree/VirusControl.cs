using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VirusControl : MonoBehaviour
{
    public static int contVirus = 7;
    Text virus;

    void Start()
    {
        virus = GetComponent<Text>();
    }

    void Update()
    {
        virus.text = "" + contVirus;
    }
}
