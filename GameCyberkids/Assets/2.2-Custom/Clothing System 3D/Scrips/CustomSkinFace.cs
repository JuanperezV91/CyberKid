using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomSkinFace : MonoBehaviour
{
    public Material[] materialFace;
    static public int xFace;
    Renderer rendFace;

    void Start()
    {
        // xPant = 0;
        rendFace = GetComponent<Renderer>();
        rendFace.enabled = true;
        rendFace.sharedMaterial = materialFace[xFace];

    }

    void Update()
    {
        rendFace.sharedMaterial = materialFace[xFace];

    }

    public void NextColorFace()
    {
        if (xFace < 3)
        {
            xFace++;
        }
        else
        {
            xFace = 0;
        }
    }
}
