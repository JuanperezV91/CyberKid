using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HockDesactivar : MonoBehaviour
{
    public GameObject PanelHockey;
    static public bool activePanelThree;
    public GameObject JuegoInit;
    public GameObject tableroH;

    public void OpenTargetThree()
    {
        
        PanelHockey.SetActive(false);
        
        ControlCamara.startCam = 0;
        tableroH.SetActive(false);
        JuegoInit.SetActive(true);
    }
 
}