using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlObjClicker : MonoBehaviour
{
    public GameObject PanelObjThree;
    static public bool activePanelThree;
    public GameObject objetivoUno;
    public GameObject objetivoDos;
    public GameObject objetivoTres;
    public GameObject objetivoCuatro;
    public GameObject objetivoCinco;
    public GameObject objetivoSeis;

    public GameObject PanelObjUno;
    public GameObject popUpObjetiveUno;

    public GameObject PanelObjDos;
    public GameObject popUpObjetiveDos;

    public GameObject PanelObjTres;
    public GameObject popUpObjetiveTres;

    public GameObject PanelObjCuatro;
    public GameObject popUpObjetiveCuatro;

    public GameObject PanelObjCinco;
    public GameObject popUpObjetiveCinco;

    public GameObject PanelObjSeis;
    public GameObject popUpObjetiveSeis;

    public static int countObj = 6;
    public static int countSeguridad = 0;

  

    void Update()
    {

        if (countObj == 3 && countSeguridad == 3)
        {
            ControlCamara.startCam = 0;
        }

        if (countObj == 0 && countSeguridad == 6)
        {

           // panelWin.SetActive(true);
            //popUpHack.SetActive(false);
            //PopUpHackDisabled.SetActive(false);
            //popUpApps.SetActive(true);

        }

        //if (HackersControl.contHackers == 1)
        //{
        //    popUpHack.SetActive(true);

        //}
    }

    public void OpenObj1()
    {
        
            PanelObjUno.SetActive(true);
            objetivoUno.SetActive(false);
            countObj -= 1;
            countSeguridad += 1;
        

    }

    public void OpenObj2()
    {
       
            PanelObjDos.SetActive(true);
            objetivoDos.SetActive(false);
            countObj -= 1;
            countSeguridad += 1;

        
    }

    public void OpenObj3()
    {
        
            PanelObjTres.SetActive(true);
            objetivoTres.SetActive(false);
            countObj -= 1;
            countSeguridad += 1;

        
    }

    public void OpenObj4()
    {
       
            PanelObjCuatro.SetActive(true);
            objetivoCuatro.SetActive(false);

        
    }

    public void OpenObj5()
    {
        
            PanelObjCinco.SetActive(true);
            objetivoCinco.SetActive(false);
                
    }

    public void OpenObj6()
    {
        
            PanelObjSeis.SetActive(true);
            objetivoSeis.SetActive(false);

    }


    //public void OpenObj1()
    //{
    //    if (PanelTargetThree != null)
    //    {
    //        bool isActive = PanelTargetThree.activeSelf;
    //        PanelTargetThree.SetActive(true);
    //        activePanelThree = true;
    //    }

    //    target3.SetActive(false);

    //    ObjetiveControl.contTargets += 1;
    //    ScoreScript.scoreValue += 10;
    //    popUpObjetiveThree.SetActive(true);
    //    ControlCamara.startCam = 2;


    //}

    //void OnMouseDown()
    //{
    //    OpenTarget();
    //}
}
