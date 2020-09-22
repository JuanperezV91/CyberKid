using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomTshirt : MonoBehaviour
{
    public Material[] materialTShirt;
    static public int xTShirt;
    Renderer rendTShirt;

    void Start()
    {

        xTShirt = PlayerPrefs.GetInt("tshirt", xTShirt);
        rendTShirt = GetComponent<Renderer>();
        rendTShirt.enabled = true;
        rendTShirt.sharedMaterial = materialTShirt[xTShirt];

    }

    void Update()
    {
        rendTShirt.sharedMaterial = materialTShirt[xTShirt];
        PlayerPrefs.SetInt("tshirt", xTShirt);

    }

    public void NextColorTShirt()
    {
        if (xTShirt < 5)
        {
            xTShirt++;
        }
        else
        {
            xTShirt = 0;
        }
    }
}
