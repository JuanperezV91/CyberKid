using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomAvatar : MonoBehaviour
{
    int currentXSkin;
    int currentXSkinArms;
    int currentXPants;
    int currentXTshirt;
    int currentXHair;

    public Material[] materiales;

    int varIndexHair;
    int varIndexTshirt;
    int varIndexSkin;
    int varIndexSkinArm;
    int varIndexPant;

    Renderer rend;
    static public int xSkinAvatar;
    Renderer rendSkinAv;
    //Hair
    static public int xHairAvatar;
    Renderer rendHairAv;
    //Pants
    static public int xPantAvatar;
    Renderer rendPantAv;
    //Tshirt
    static public int xTShirtAvatar;
    Renderer rendTShirtAv;
    //SkinArms
    static public int xSkinArmsAvatar;
    Renderer rendSkinArmsAv;
    
    void Start()
    {

        // xPant = 0;

        if (xPantAvatar != currentXPants) //Pants
        {
            currentXPants = xPantAvatar;
            rendPantAv = GetComponent<Renderer>();
            rendPantAv.enabled = true;
            rendPantAv.sharedMaterial = materiales[currentXPants];
        }
        else
           if (xSkinAvatar != currentXSkin) //Skins
        {
            currentXSkin = xSkinAvatar;
            //  xSkin = 0;
            rendSkinAv = GetComponent<Renderer>();
            rendSkinAv.enabled = true;
            rendSkinAv.sharedMaterial = materiales[currentXSkin];
        }
        else
           if (xHairAvatar != currentXHair) //Hair
        {
            currentXHair = xHairAvatar;
            // xHair = 0;
            rendHairAv = GetComponent<Renderer>();
            rendHairAv.enabled = true;
            rendHairAv.sharedMaterial = materiales[currentXHair];
        }
        else
           if (xTShirtAvatar != currentXTshirt)//Tshirt
        {
            currentXTshirt = xTShirtAvatar;
            // xTShirt = 0;
            rendTShirtAv = GetComponent<Renderer>();
            rendTShirtAv.enabled = true;
            rendTShirtAv.sharedMaterial = materiales[currentXTshirt];
        }
        else
           if (xSkinArmsAvatar != currentXSkinArms)//Skin Arms
        {
            currentXSkinArms = xSkinArmsAvatar;
            // xSkinArms = 0;
            rendSkinArmsAv = GetComponent<Renderer>();
            rendSkinArmsAv.enabled = true;
            rendSkinArmsAv.sharedMaterial = materiales[currentXSkinArms];

        }

        LoadCustom();


    }

    void Update()
    {
        rendSkinAv.sharedMaterial = materiales[xSkinAvatar];
        rendHairAv.sharedMaterial = materiales[xHairAvatar];
        rendSkinAv.sharedMaterial = materiales[xSkinAvatar];
        rendTShirtAv.sharedMaterial = materiales[xTShirtAvatar];
        rendSkinArmsAv.sharedMaterial = materiales[xSkinArmsAvatar];

        if (xPantAvatar != currentXPants) //Pants
        {
            currentXPants = xPantAvatar;           
            rendPantAv.sharedMaterial = materiales[currentXPants];
        }
        else
          if (xSkinAvatar != currentXSkin) //Skins
        {
            currentXSkin = xSkinAvatar;           
            rendSkinAv.sharedMaterial = materiales[currentXSkin];
        }
        else
          if (xHairAvatar != currentXHair) //Hair
        {
            currentXHair = xHairAvatar;     
            rendHairAv.sharedMaterial = materiales[currentXHair];
        }
        else
          if (xTShirtAvatar != currentXTshirt)//Tshirt
        {
            currentXTshirt = xTShirtAvatar;           
            rendTShirtAv.sharedMaterial = materiales[currentXTshirt];
        }
        else
          if (xSkinArmsAvatar != currentXSkinArms)//Skin Arms
        {
            currentXSkinArms = xSkinArmsAvatar;          
            rendSkinArmsAv.sharedMaterial = materiales[currentXSkinArms];

        }      

        SaveCustom();

    }
    
    public void NextColorSkin()
    {
        if (xSkinAvatar < 3) // 3
        {
            xSkinAvatar++;
        }
        else
        {
            xSkinAvatar = 0;
        }
        // SaveCustom();

        //  xSkin = 0;
        rendSkinAv = GetComponent<Renderer>();
        rendSkinAv.enabled = true;
        rendSkinAv.sharedMaterial = materiales[xSkinAvatar];

        varIndexSkin = xSkinAvatar;


    }


    //SkinArms

    public void NextColorSkinArms()
    {
        

        if (xSkinArmsAvatar < 3) // 3
        {
            xSkinArmsAvatar++;
        }
        else
        {
            xSkinArmsAvatar = 0;
        }
        // SaveCustom();

        // xSkinArms = 0;
        rendSkinArmsAv = GetComponent<Renderer>();
        rendSkinArmsAv.enabled = true;
        rendSkinArmsAv.sharedMaterial = materiales[xSkinArmsAvatar];

        varIndexSkinArm = xSkinArmsAvatar;
    }

    //CustomHair


    public void NextColorHair()
    {

 

        if (xHairAvatar < 3) // 3
        {
            xHairAvatar++;
        }
        else
        {
            xHairAvatar = 0;
        }

        // xHair = 0;
        rendHairAv = GetComponent<Renderer>();
        rendHairAv.enabled = true;
        rendHairAv.sharedMaterial = materiales[xHairAvatar];
        // SaveCustom();
        varIndexHair = xHairAvatar;
    }

    //Pants

    public void NextColorPants()
    {
                     
        if (xPantAvatar < 5) // 5
        {
            xPantAvatar++;
        }
        else
        {
            xPantAvatar = 0;
        }

        rendPantAv = GetComponent<Renderer>();
        rendPantAv.enabled = true;
        rendPantAv.sharedMaterial = materiales[xPantAvatar];
        varIndexPant = xPantAvatar;
        //  SaveCustom();

    }

    //TShirt

    public void NextColorTShirt()
    {
       

        if (xTShirtAvatar < 6) //6
        {
            xTShirtAvatar++;
        }
        else
        {
            xTShirtAvatar = 0;
        }

        rendTShirtAv = GetComponent<Renderer>();
        rendTShirtAv.enabled = true;
        rendTShirtAv.sharedMaterial = materiales[xTShirtAvatar];
        varIndexTshirt = xTShirtAvatar;
        //  SaveCustom();

    }

    
    //Save and Load
    public static void SaveCustom()
    {
        PlayerPrefs.SetInt("Pants", xPantAvatar);
        PlayerPrefs.SetInt("Tshirt", xTShirtAvatar);
        PlayerPrefs.SetInt("SkinArms", xSkinArmsAvatar);
        PlayerPrefs.SetInt("Skin", xSkinAvatar);
        PlayerPrefs.SetInt("Hair", xHairAvatar);
        // PlayerPrefs.Save();        
       /* rendSkinAv.sharedMaterial = materiales[xSkinAvatar];
        rendHairAv.sharedMaterial = materiales[xHairAvatar];
        rendPantAv.sharedMaterial = materiales[xPantAvatar];
        rendTShirtAv.sharedMaterial = materiales[xTShirtAvatar];
        rendSkinArmsAv.sharedMaterial = materiales[xSkinArmsAvatar];        
        Debug.Log(xPantAvatar);
        Debug.Log(xTShirtAvatar);
        Debug.Log(xSkinArmsAvatar);
        Debug.Log(xSkinAvatar);
        Debug.Log(xHairAvatar);*/

    }
    public static void LoadCustom()
    {
        xPantAvatar = PlayerPrefs.GetInt("Pants",0);
        xTShirtAvatar = PlayerPrefs.GetInt("Tshirt",0);
        xSkinArmsAvatar = PlayerPrefs.GetInt("SkinArms",0);
        xSkinAvatar = PlayerPrefs.GetInt("Skin",0);
        xHairAvatar = PlayerPrefs.GetInt("Hair",0);

        /*
        rendPantAv = GetComponent<Renderer>();
        rendPantAv.enabled = true;
        rendPantAv.sharedMaterial = materiales[xPantAvatar];

        //  xSkin = 0;
        rendSkinAv = GetComponent<Renderer>();
        rendSkinAv.enabled = true;
        rendSkinAv.sharedMaterial = materiales[xSkinAvatar];

        // xHair = 0;
        rendHairAv = GetComponent<Renderer>();
        rendHairAv.enabled = true;
        rendHairAv.sharedMaterial = materiales[xHairAvatar];

        // xTShirt = 0;
        rendTShirtAv = GetComponent<Renderer>();
        rendTShirtAv.enabled = true;
        rendTShirtAv.sharedMaterial = materiales[xTShirtAvatar];

        // xSkinArms = 0;
        rendSkinArmsAv = GetComponent<Renderer>();
        rendSkinArmsAv.enabled = true;
        rendSkinArmsAv.sharedMaterial = materiales[xSkinArmsAvatar];
        
        
    */
    }
}
