using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HockeyLevel : MonoBehaviour
{
    public GameObject PanelHockey;
    static public bool activePanelThree;
    public GameObject JuegoInit;
    public GameObject tableroH;

    public void OpenTargetThree()
    {
        if (PanelHockey != null)
        {
            bool isActive = PanelHockey.activeSelf;
            PanelHockey.SetActive(true);
            activePanelThree = true;
        }

        ControlCamara.startCam = 2;

        tableroH.SetActive(true);
        JuegoInit.SetActive(false); 
    }

    void OnMouseDown()
    {
        OpenTargetThree();
    }
}
