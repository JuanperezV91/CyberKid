using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetClickerObjetives : MonoBehaviour
{

    public static int currentCountObj;
    public static int currentCountSeguridad;

    public GameObject objetivoSec;
    public GameObject pnlObjetivo;
    static public bool activePanelObj;


    public void AbrirObjetivo()
    {
        if (pnlObjetivo != null)
        {
            bool isActive = pnlObjetivo.activeSelf;
            pnlObjetivo.SetActive(true);
            activePanelObj = true;
        }

        objetivoSec.SetActive(false);

        //Contador de Objetivos Disminuye
        CountValuesObj.countObj -= 1;
        

        ScoreScript.scoreValue += 10;

        if (ControlObjAns.countSeguridad == 3)
        {
            ControlCamara.startCam = 0;
        }
    }

    void OnMouseDown()
    {
        AbrirObjetivo();
    }
}
