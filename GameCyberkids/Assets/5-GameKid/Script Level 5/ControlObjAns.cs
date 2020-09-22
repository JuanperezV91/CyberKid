using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlObjAns : MonoBehaviour
{
    public AudioSource audioCorrect;
    public AudioSource audioIncorrect;
    public GameObject buttonOne;
    public GameObject buttonTwo;
    public GameObject buttonThree;
    public GameObject pnlRestantes;

    public static int countSeguridad;



    public GameObject PanelDesactivar;
    public GameObject PanelWin;   
    public GameObject PnlIncorrect;

    bool answerOption = false;   

    void Start()
    {
        countSeguridad = 0;
    }

    void Update()
    {
        if (CountValuesObj.countObj == 0 && countSeguridad == 6)
        {
            PanelWin.SetActive(true);
        }

        if (CountValuesObj.countObj == 2 && countSeguridad == 4)
        {
            pnlRestantes.SetActive(true);
        }
        else
        {
            pnlRestantes.SetActive(false);
        }
    }

    public void correctAnswer()
    {
        audioCorrect.Play();
       // PanelWin.SetActive(true);
        ScoreScript.scoreValue += 100;
        PanelDesactivar.SetActive(false);
        countSeguridad += 1;
    }

    public void incorrectAnswer()
    {
        audioIncorrect.Play();
        PnlIncorrect.SetActive(true);

    }
}
