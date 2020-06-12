using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomSkinArms : MonoBehaviour
{
    public Material[] materialSkinArms;
    static public int xSkinArms;
    Renderer rendSkinArms;

    void Start()
    {

       // xSkinArms = 0;
        rendSkinArms = GetComponent<Renderer>();
        rendSkinArms.enabled = true;
        rendSkinArms.sharedMaterial = materialSkinArms[xSkinArms];

    }

    void Update()
    {
        rendSkinArms.sharedMaterial = materialSkinArms[xSkinArms];
    }

    public void NextColorSkinArms()
    {
        if (xSkinArms < 3)
        {
            xSkinArms++;
        }
        else
        {
            xSkinArms = 0;
        }
    }

    /* int currentX;
    public Material[] materials;

    static public int varIndexHair;
    static public int varIndexTshirt;
    static public int varIndexSkin;
    static public int varIndexSkinArm;
    static public int varIndexPant;

    public Renderer rend;
    static public int xSkin;
    public Renderer rendSkin;
    //Hair
    static public int xHair;
    public Renderer rendHair;
    //Pants
    static public int xPant;
    public Renderer rendPant;
    //Tshirt
    static public int xTShirt;
    public Renderer rendTShirt;
    //SkinArms
    static public int xSkinArms;
    public Renderer rendSkinArms;

    void Start()
    {
        //LoadCustom();

        rendPant = GetComponent<Renderer>();
        rendPant.enabled = true;
        rendPant.sharedMaterial = materials[varIndexPant];

        //  xSkin = 0;
        rendSkin = GetComponent<Renderer>();
        rendSkin.enabled = true;
        rendSkin.sharedMaterial = materials[varIndexSkin];

        // xHair = 0;
        rendHair = GetComponent<Renderer>();
        rendHair.enabled = true;
        rendHair.sharedMaterial = materials[varIndexHair];

        // xTShirt = 0;
        rendTShirt = GetComponent<Renderer>();
        rendTShirt.enabled = true;
        rendTShirt.sharedMaterial = materials[varIndexTshirt];

        // xSkinArms = 0;
        rendSkinArms = GetComponent<Renderer>();
        rendSkinArms.enabled = true;
        rendSkinArms.sharedMaterial = materials[varIndexSkinArm];

    }

    void Update()
    {
        // SaveCustom();

         rendHair.sharedMaterial = materials[varIndexHair];       
         rendPant.sharedMaterial = materials[varIndexPant];     
         rendSkin.sharedMaterial = materials[varIndexSkin];        
         rendSkinArms.sharedMaterial = materials[varIndexSkinArm];       
         rendTShirt.sharedMaterial = materials[varIndexTshirt];



        /*
        rend.sharedMaterial = materials[xSkin];
        rend.sharedMaterial = materials[xHair];
        rend.sharedMaterial = materials[xPant];
        rend.sharedMaterial = materials[xTShirt];
        rend.sharedMaterial = materials[xSkinArms];
        }

    /*
    void Start()
    {

        LoadCustom();
        // xPant = 0;

        if (xPant != currentX) //Pants
        {
            currentX = xPant;
            rendPant = GetComponent<Renderer>();
            rendPant.enabled = true;
            rendPant.sharedMaterial = materials[currentX];
        }
        else
           if (xSkin != currentX) //Skins
        {
            currentX = xSkin;
            //  xSkin = 0;
            rendSkin = GetComponent<Renderer>();
            rendSkin.enabled = true;
            rendSkin.sharedMaterial = materials[currentX];
        }
        else
           if (xHair != currentX) //Hair
        {
            currentX = xHair;
            // xHair = 0;
            rendHair = GetComponent<Renderer>();
            rendHair.enabled = true;
            rendHair.sharedMaterial = materials[currentX];
        }
        else
           if (xTShirt != currentX)//Tshirt
        {
            currentX = xTShirt;
            // xTShirt = 0;
            rendTShirt = GetComponent<Renderer>();
            rendTShirt.enabled = true;
            rendTShirt.sharedMaterial = materials[currentX];
        }
        else
           if (xSkinArms != currentX)//Skin Arms
        {
            currentX = xSkinArms;
            // xSkinArms = 0;
            rendSkinArms = GetComponent<Renderer>();
            rendSkinArms.enabled = true;
            rendSkinArms.sharedMaterial = materials[currentX];

        }
        
    }

    void Update()
    {
      /*  rendSkin.sharedMaterial = materials[xSkin];
        rendHair.sharedMaterial = materials[xHair];
        rendSkin.sharedMaterial = materials[xSkin];
        rendTShirt.sharedMaterial = materials[xTShirt];
        rendSkinArms.sharedMaterial = materials[xSkinArms];

        if (xPant != currentX) //Pants
        {
            currentX = xPant;
            rendPant.sharedMaterial = materials[currentX];
        }else
            if(xSkin != currentX) //Skins
        {
            currentX = xSkin;
            rendSkin.sharedMaterial = materials[currentX];
        }else
            if(xHair != currentX) //Hair
        {
            currentX = xHair;
            rendHair.sharedMaterial = materials[currentX];
        }else
            if (xTShirt != currentX)//Tshirt
        {
            currentX = xTShirt;
            rendTShirt.sharedMaterial = materials[currentX];
        }else
            if (xSkinArms != currentX)//Skin Arms
        {
            currentX = xSkinArms;
            rendSkinArms.sharedMaterial = materials[currentX];

        }

        SaveCustom();

    }
    
    public void NextColorSkin()
    {
         xSkin = 0;
        if (xSkin < 3) // 3
        {
            xSkin++;
        }
        else
        {
            xSkin = 0;
        }
        // SaveCustom();

        //  xSkin = 0;
        rendSkin = GetComponent<Renderer>();
        rendSkin.enabled = true;
        rendSkin.sharedMaterial = materials[xSkin];

        varIndexSkin = xSkin;


    }


    //SkinArms

    public void NextColorSkinArms()
    {
         xSkinArms = 4;


        if (xSkinArms > 3 && xSkinArms < 7) // 3
        {
            xSkinArms++;
        }
        else
        {
            xSkinArms = 0;
        }
        // SaveCustom();

        // xSkinArms = 0;
        rendSkinArms = GetComponent<Renderer>();
        rendSkinArms.enabled = true;
        rendSkinArms.sharedMaterial = materials[xSkinArms];

        varIndexSkinArm = xSkinArms;
    }

    //CustomHair


    public void NextColorHair()
    {

         xHair = 8;

        if (xHair > 7 && xHair < 12) // 3
        {
            xHair++;
        }
        else
        {
            xHair = 0;
        }

        // xHair = 0;
        rendHair = GetComponent<Renderer>();
        rendHair.enabled = true;
        rendHair.sharedMaterial = materials[xHair];
        // SaveCustom();
        varIndexHair = xHair;
    }

    //Pants

    public void NextColorPants()
    {
        xPant = 12;
                     
        if (xPant > 11 && xPant < 18) // 5
        {
            xPant++;
        }
        else
        {
            xPant = 0;
        }

        rendPant = GetComponent<Renderer>();
        rendPant.enabled = true;
        rendPant.sharedMaterial = materials[xPant];
        varIndexPant = xPant;
        //  SaveCustom();

    }

    //TShirt

    public void NextColorTShirt()
    {
         xTShirt = 18;
       

        if (xTShirt > 17 && xTShirt < 24) //6
        {
            xTShirt++;
        }
        else
        {
            xTShirt = 0;
        }

        rendTShirt = GetComponent<Renderer>();
        rendTShirt.enabled = true;
        rendTShirt.sharedMaterial = materials[xTShirt];
        varIndexTshirt = xTShirt;
        //  SaveCustom();

    }

    
    //Save and Load
    public static void SaveCustom()
    {
        PlayerPrefs.SetInt("Pants", xPant);
        PlayerPrefs.SetInt("Tshirt", xTShirt);
        PlayerPrefs.SetInt("SkinArms", xSkinArms);
        PlayerPrefs.SetInt("Skin", xSkin);
        PlayerPrefs.SetInt("Hair", xHair);
       // PlayerPrefs.Save();
        /*
        rend.sharedMaterial = materials[xSkin];
        rend.sharedMaterial = materials[xHair];
        rend.sharedMaterial = materials[xPant];
        rend.sharedMaterial = materials[xTShirt];
        rend.sharedMaterial = materials[xSkinArms];
        
        Debug.Log(xPant);
        Debug.Log(xTShirt);
        Debug.Log(xSkinArms);
        Debug.Log(xSkin);
        Debug.Log(xHair);

    }
    public static void LoadCustom()
    {
        xPant = PlayerPrefs.GetInt("Pants");
        xTShirt = PlayerPrefs.GetInt("Tshirt");
        xSkinArms = PlayerPrefs.GetInt("SkinArms");
        xSkin = PlayerPrefs.GetInt("Skin");
        xHair = PlayerPrefs.GetInt("Hair");

        /*
        rendPant = GetComponent<Renderer>();
        rendPant.enabled = true;
        rendPant.sharedMaterial = materials[varIndexPant];

        //  xSkin = 0;
        rendSkin = GetComponent<Renderer>();
        rendSkin.enabled = true;
        rendSkin.sharedMaterial = materials[varIndexSkin];

        // xHair = 0;
        rendHair = GetComponent<Renderer>();
        rendHair.enabled = true;
        rendHair.sharedMaterial = materials[varIndexHair];

        // xTShirt = 0;
        rendTShirt = GetComponent<Renderer>();
        rendTShirt.enabled = true;
        rendTShirt.sharedMaterial = materials[varIndexTshirt];

        // xSkinArms = 0;
        rendSkinArms = GetComponent<Renderer>();
        rendSkinArms.enabled = true;
        rendSkinArms.sharedMaterial = materials[varIndexSkinArm];

        /*rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[xPant];

        //  xSkin = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[xSkin];

        // xHair = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[xHair];

        // xTShirt = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[xTShirt];

        // xSkinArms = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[xSkinArms];

    }*/

}
