using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGlass : MonoBehaviour
{
    public Material[] material;
    public int xGlasses;
    public int xGlassesWhite;

    Renderer rend;

    public void NextColorGlassBlue()
    {
        xGlasses = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[xGlasses];

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
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[xGlasses];

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
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[xGlasses];

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
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[xGlasses];

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
