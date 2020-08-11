using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswerT1 : MonoBehaviour
{


    public AudioSource audioCorrect;
    public AudioSource audioIncorrect;
    public GameObject buttonOne;
    public GameObject buttonTwo;
    public GameObject buttonThree;
    public int countAns;
    public int countAns2;
    public int countAns3;


    public GameObject PanelDesactivar;
    public GameObject PanelWin;
    public GameObject PanelWin2;
    public GameObject PanelWin3;

    bool answerOption = false;

    void Start()
    {
        countAns = 3;
        countAns2 = 2;
        countAns3 = 1;

    }

    void Update()
    {
        if(countAns == 0)
        {
            PanelWin.SetActive(true);
        }

        if(countAns2 == 0)
        {
            PanelWin2.SetActive(true);
            PanelDesactivar.SetActive(false);
        }

        if (countAns3 == 0)
        {
            PanelWin3.SetActive(true);
            PanelDesactivar.SetActive(false);
        }
    }
    
    public void correctAnswer()
    {
        audioCorrect.Play();
        PanelWin.SetActive(true);
        ScoreScript.scoreValue += 100;

    }

    public void correctAnswer1()
    {
        audioCorrect.Play();
        ScoreScript.scoreValue += 100;
        countAns -= 1;
        countAns2 -= 1;

        if (countAns2 == 0)
        {            
            PanelDesactivar.SetActive(false);
        }

        buttonOne.SetActive(false);
        
    }

    public void correctAnswer2()
    {
        audioCorrect.Play();
        ScoreScript.scoreValue += 100;
        countAns -= 1;
        countAns2 -= 1;


        if (countAns2 == 0)
        {
            PanelDesactivar.SetActive(false);
        }

        buttonTwo.SetActive(false);

    }

    public void correctAnswer3()
    {
        audioCorrect.Play();
        ScoreScript.scoreValue += 100;
        countAns -= 1;
        countAns2 -= 1;


        if (countAns2 == 0)
        {
            PanelDesactivar.SetActive(false);
        }

        buttonThree.SetActive(false);

    }


    public void incorrectAnswer()
    {
        audioIncorrect.Play();
        PanelWin.SetActive(false);
        
    }
}
