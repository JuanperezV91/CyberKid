using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizationManager : MonoBehaviour
{
    public Material[] material;
    public Material[] materialGlasses;
    public Material[] materialGlass;
    public Material[] materialPants;

    static public int x;
    static public int indexGlasses;
    static public int xGlass;
    static public int xPants;

    Renderer rendPants;
    Renderer rend;
    Renderer rendGlasses;
    Renderer rendGlass;


    enum AppearanceDetails {
        HAIR_MODEL,
        GLASSES_MODEL,
        TSHIRT_MODEL,
        PANTS_MODEL,
        CAPS_MODEL


            }

     
    [SerializeField] private GameObject[] hairModels;
    [SerializeField] private Transform Head;

    [SerializeField] private GameObject[] capsModel;
    [SerializeField] private Transform Cap;

    [SerializeField] private GameObject[] glassesModel;
    [SerializeField] private Transform Glasses;

    [SerializeField] private GameObject[] tshirtsModel;
    [SerializeField] private Transform Tshirt;


    private GameObject hips;
    GameObject activeHair;
    GameObject activeCap;
    GameObject activeGlass;
    GameObject activeTshirt;

    GameObject HairBoy;

    static int hairIndex =0;
    static int capIndex = 0;
    static int glassIndex = 0;
    static int tshirtIndex = 0;

    void Start()
    {
       // x = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[x];

       // xPants = 0;
        rendPants = GetComponent<Renderer>();
        rendPants.enabled = true;
        rendPants.sharedMaterial = material[xPants];
        
        //Glasses Frame
       //  indexGlasses = 0;
        rendGlasses = GetComponent<Renderer>();
        rendGlasses.enabled = true;
        rendGlasses.sharedMaterial = materialGlasses[indexGlasses];
        //Glass
      //  xGlass = 0;
        rendGlass = GetComponent<Renderer>();
        rendGlass.enabled = true;
        rendGlass.sharedMaterial = materialGlass[xGlass];



    }

    void Update()
    {
        rendPants.sharedMaterial = material[xPants];
        rend.sharedMaterial = material[x];
        rendGlasses.sharedMaterial = materialGlasses[indexGlasses];
        rendGlass.sharedMaterial = materialGlass[xGlass];
               
    }

    //Tshirt
    public void NextColorTshirt()
    {
        if (x < 7)
        {
            x++;
        }
        else
        {
            x = 0;
        }
    }

    public void NextColorPants()
    {
        if (xPants < 7)
        {
            xPants++;
        }
        else
        {
            xPants = 0;
        }
    }


    //Glass Frame
    public void ColorGlassFrame()
    {
        if (indexGlasses < 1)
        {
            indexGlasses++;
        }
        else
        {
            indexGlasses = 0;
        }
    }
    //Glass
    public void ColorGlass()
    {
        if (xGlass < 1)
        {
            xGlass++;
        }
        else
        {
            xGlass = 0;
        }
    }



    //Hair
    public void HairModelUp()
    {
        if (hairIndex < hairModels.Length - 1)
        {
            hairIndex++;
            hips = GameObject.FindWithTag("hips");
            DestroyObject(hips);
        }
        else
        {
            hairIndex = 0;

        }
        ApplyModification(AppearanceDetails.HAIR_MODEL, hairIndex);
        
    }

    public void HairModelDown()
    {
        if (hairIndex > 0)
        {
            hairIndex--;
        }
        else
        {

            hairIndex = hairModels.Length - 1;
        }
        ApplyModification(AppearanceDetails.HAIR_MODEL, hairIndex);

        }


        public void CapsModelUp()
    {
        if (capIndex < capsModel.Length - 1)
        {
            capIndex++;
            
        }
        else
        {
            capIndex = 0;

        }
        ApplyModification(AppearanceDetails.CAPS_MODEL, capIndex);

    }


    public void CapsModelDown()
    {
        if (capIndex > 0)
        {
            capIndex--;
        }
        else
        {

            capIndex = capsModel.Length - 1;
        }
        ApplyModification(AppearanceDetails.CAPS_MODEL, capIndex);


    }

    //Atuendo superior
    public void TshirtModelUp()
    {
        if (tshirtIndex < tshirtsModel.Length - 1)
        {
            tshirtIndex++;

        }
        else
        {
            tshirtIndex = 0;

        }
        ApplyModification(AppearanceDetails.TSHIRT_MODEL, tshirtIndex);

    }


    public void TshirtModelDown()
    {
        if (tshirtIndex > 0)
        {
            tshirtIndex--;
        }
        else
        {

            tshirtIndex = tshirtsModel.Length - 1;
        }
        ApplyModification(AppearanceDetails.TSHIRT_MODEL, tshirtIndex);


    }

    public void GlassModelUp()
    {
        if (glassIndex < glassesModel.Length - 1)
        {
            glassIndex++;

        }
        else
        {
            glassIndex = 0;

        }
        ApplyModification(AppearanceDetails.GLASSES_MODEL, glassIndex);

    }

  
    void ApplyModification(AppearanceDetails detail, int id)
    {
        switch (detail)
        {
            case AppearanceDetails.HAIR_MODEL:
                if (activeHair != null)
                    GameObject.Destroy(activeHair);
                activeHair = GameObject.Instantiate(hairModels[id]);
                activeHair.transform.SetParent(Head);
                activeHair.transform.ResetTransform();
                break;
            case AppearanceDetails.CAPS_MODEL:
                if (activeCap != null)
                    GameObject.Destroy(activeCap);
                activeCap = GameObject.Instantiate(capsModel[id]);
                activeCap.transform.SetParent(Cap);
                //activeCap.transform.ResetTransform();
                break;
            case AppearanceDetails.GLASSES_MODEL:
                if (activeGlass != null)
                    GameObject.Destroy(activeGlass);
                activeGlass = GameObject.Instantiate(glassesModel[id]);
                activeGlass.transform.SetParent(Glasses);
                //activeCap.transform.ResetTransform();
                break;
            case AppearanceDetails.TSHIRT_MODEL:
                if (activeTshirt != null)
                    GameObject.Destroy(activeTshirt);
                activeTshirt = GameObject.Instantiate(tshirtsModel[id]);
                activeTshirt.transform.SetParent(Tshirt);
                //activeCap.transform.ResetTransform();
                break;

        }
    /* HairBoy.transform.ResetTransform();
        hips = GameObject.FindGameObjectWithTag("hips");
        DestroyObject(hips);
    */

    }



}
