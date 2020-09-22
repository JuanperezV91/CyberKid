using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGlass : MonoBehaviour
{
    public Material[] material;
    static public int xGlasses;
    static public int xGlassesWhite;

    Renderer rendBlack;
    Renderer rendWhite;
    Renderer rendBlue;
    
    Renderer rendDefault;




    void Start()
    {

        xGlasses = PlayerPrefs.GetInt("xglasses", xGlasses);

        rendDefault = GetComponent<Renderer>();
        rendDefault.enabled = true;
        rendDefault.sharedMaterial = material[xGlasses];
        // xPant = 0;
        rendBlue = GetComponent<Renderer>();
        rendBlue.enabled = true;
        rendBlue.sharedMaterial = material[xGlasses];
                
        // xPant = 0;
        rendWhite = GetComponent<Renderer>();
        rendWhite.enabled = true;
        rendWhite.sharedMaterial = material[xGlasses];

        // xPant = 0;
        rendBlack = GetComponent<Renderer>();
        rendBlack.enabled = true;
        rendBlack.sharedMaterial = material[xGlasses];

    }

    void Update()
    {
        PlayerPrefs.SetInt("xglasses", xGlasses);

        rendBlue.sharedMaterial = material[xGlasses];
        rendWhite.sharedMaterial = material[xGlasses];
        rendBlack.sharedMaterial = material[xGlasses];
        rendDefault.sharedMaterial = material[xGlasses];

    }

    public void NextColorGlassBlue()
    {
        xGlasses = 0;
        rendBlue = GetComponent<Renderer>();
        rendBlue.enabled = true;
        rendBlue.sharedMaterial = material[xGlasses];

       /* if (xGlasses < 1)
        {
            xGlasses++;
        }
        else
        {
            xGlasses = 0;
        }*/
    }

    public void NextColorGlassWhite()
    {
        xGlasses = 1;
        rendWhite = GetComponent<Renderer>();
        rendWhite.enabled = true;
        rendWhite.sharedMaterial = material[xGlasses];

        /* if (xGlasses < 1)
         {
             xGlasses++;
         }
         else
         {
             xGlasses = 0;
         }*/
    }

    public void NextColorGlassBlack()
    {
        xGlasses = 2;
        rendBlack = GetComponent<Renderer>();
        rendBlack.enabled = true;
        rendBlack.sharedMaterial = material[xGlasses];

        /* if (xGlasses < 1)
         {
             xGlasses++;
         }
         else
         {
             xGlasses = 0;
         }*/
    }

    public void NextColorGlassDefault()
    {
        xGlasses = 3;
        rendDefault = GetComponent<Renderer>();
        rendDefault.enabled = true;
        rendDefault.sharedMaterial = material[xGlasses];

        /* if (xGlasses < 1)
         {
             xGlasses++;
         }
         else
         {
             xGlasses = 0;
         }*/
    }
}
