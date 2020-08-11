using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlInsta : MonoBehaviour
{
    public AudioSource audioCorrect;
    public AudioSource audioIncorrect;
    public int countAnsI;
    public GameObject PanelWinT;


    void Start()
    {
        countAnsI = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (countAnsI == 0)
        {
            PanelWinT.SetActive(true);
        }
    }

    public void correctAnswer1()
    {
        audioCorrect.Play();
        ScoreScript.scoreValue += 100;
        countAnsI -= 1;
    }
}
