﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomHair : MonoBehaviour
{
    public Material[] materialHair;
    static public int xHair;
    Renderer rendHair;

    void Start()
    {

       // xHair = 0;
        rendHair = GetComponent<Renderer>();
        rendHair.enabled = true;
        rendHair.sharedMaterial = materialHair[xHair];

    }

    void Update()
    {
        rendHair.sharedMaterial = materialHair[xHair];
    }

    public void NextColorHair()
    {
        if (xHair < 3)
        {
            xHair++;
        }
        else
        {
            xHair = 0;
        }
    }
}
