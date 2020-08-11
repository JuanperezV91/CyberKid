using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetClickerTwo : MonoBehaviour
{
    public GameObject PanelTargetTwo;
    public GameObject HandPoint;
    static public bool activePanelTwo;
    public GameObject target2;


    public void OpenTargetTwo()
    {
        if (PanelTargetTwo != null)
        {
            bool isActive = PanelTargetTwo.activeSelf;
            PanelTargetTwo.SetActive(true);
            HandPoint.SetActive(true);
            activePanelTwo = true;
            target2.SetActive(false);
        }

        ObjetiveControl.contTargets += 1;
        ScoreScript.scoreValue += 10;
        ControlCamara.startCam = 2;


    }

    void OnMouseDown()
    {
        OpenTargetTwo();
    }

}
