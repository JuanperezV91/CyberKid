using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetClickerFive : MonoBehaviour
{
    public GameObject PanelTargetFive;
    static public bool activePanelFive;
    public GameObject target5;

    public void OpenTargetFive()
    {
        if (PanelTargetFive != null)
        {
            bool isActive = PanelTargetFive.activeSelf;
            PanelTargetFive.SetActive(true);
            activePanelFive = true;
            target5.SetActive(false);
        }
       
        ObjetiveControl.contTargets += 1;
        ScoreScript.scoreValue += 10;


    }

    void OnMouseDown()
    {
        OpenTargetFive();
    }
}
