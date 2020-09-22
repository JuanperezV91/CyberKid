using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomPant : MonoBehaviour
{
    public Material[] materialPant;    
    static public int xPant;
    int currentX;
    Renderer rendPant;
    
    void Start()
    {
        xPant = PlayerPrefs.GetInt("pants", xPant);
        rendPant = GetComponent<Renderer>();
        rendPant.enabled = true;
        rendPant.sharedMaterial = materialPant[xPant];

    }
   
    void Update()
    {
       rendPant.sharedMaterial = materialPant[xPant];
        PlayerPrefs.SetInt("pants", xPant);

    }

    public void NextColorPants()
    {
        if (xPant < 5)
        {
            xPant++;
        }
        else
        {
            xPant = 0;
        }
    }
}
