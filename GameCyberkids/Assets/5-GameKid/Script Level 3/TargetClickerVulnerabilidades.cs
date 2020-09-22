using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetClickerVulnerabilidades : MonoBehaviour
{
    public GameObject PanelTargetThree;
    static public bool activePanelThree;
    public GameObject target3;
    public GameObject popUpObjetiveThree;
    public GameObject objetivoUno;
    public GameObject objetivoDos;
    public GameObject objetivoTres;
    public GameObject objetivoCuatro;
    public GameObject objetivoCinco;
    public GameObject objetivoSeis;

    public void OpenTarget()
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
        ControlCamara.startCam = 2;
       
        objetivoUno.SetActive(true);
        objetivoDos.SetActive(true);
        objetivoTres.SetActive(true);
        objetivoCuatro.SetActive(true);
        objetivoCinco.SetActive(true);
        objetivoSeis.SetActive(true);
    }

    void OnMouseDown()
    {
        OpenTarget();
    }
}
