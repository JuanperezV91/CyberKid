﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl4_obj2 : MonoBehaviour
{
    public GameObject PanelTargetOne;
    [SerializeField] public QuizManager quizMan;
    static public bool activePanel;
    public GameObject target1;
 //   public GameObject popUpObjetiveOne;


    void Start()
    {
   //     popUpObjetiveOne.SetActive(true);
    }

    public void OpenTargetOne()
    {
        if (PanelTargetOne != null)
        {
            bool isActive = PanelTargetOne.activeSelf;
            PanelTargetOne.SetActive(true);
            activePanel = true;
            quizMan.StartGame(0);
            target1.SetActive(false);
        //    popUpObjetiveOne.SetActive(false);
        }
  
        ObjetiveControl.contTargets += 1;
        ScoreScript.scoreValue += 10;


    }

    public void CloseTargetOne()
    {
        if (PanelTargetOne != null)
        {
            PanelTargetOne.SetActive(false);
            activePanel = false;
        }
    }



    void OnMouseDown()
    {
        OpenTargetOne();
    }

}
