using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetClickerThree : MonoBehaviour
{
    public GameObject PanelTargetThree;
    static public bool activePanelThree;
    public GameObject target3;
    public GameObject popUpObjetiveThree;

    public void OpenTargetThree()
    {
        if (PanelTargetThree != null)
        {
            bool isActive = PanelTargetThree.activeSelf;
            PanelTargetThree.SetActive(true);
            activePanelThree = true;
        }

        target3.SetActive(false);

        ObjetiveControl.contTargets += 1;
        ScoreScript.scoreValue += 10;
        popUpObjetiveThree.SetActive(true);


    }

    void OnMouseDown()
    {
        OpenTargetThree();
    }
}
