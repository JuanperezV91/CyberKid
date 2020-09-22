using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ComenzarJuegoNivel : MonoBehaviour
{
    public GameObject act_target;
    public GameObject desc_tutorial;
    // public GameObject act_temporizador;
    private float timeLimit = 120f;
    private float currentTimer;
    public GameObject pnlResultados;
    public Text TimerText;
    public GameObject timeHolder;
    public GameObject pnlGameOver;


    void Start()
    {
       // pnlResultados.SetActive(tr);
    }

    void Update()
    {
       

        if (timeHolder.activeSelf == true)
        {
            currentTimer -= Time.deltaTime;
            SetTimer(currentTimer);
        }      
    }

    public void comenzarJuego()
    {
        Comenzar();
    }


    public void saltarTutorial()
    {
        Comenzar();
        desc_tutorial.SetActive(false);
    }

    public void Comenzar()
    {
       
        currentTimer = timeLimit;
        act_target.SetActive(true);
        timeHolder.SetActive(true);


    }

    //Set Timer
    private void SetTimer(float value)
    {
        TimeSpan time = TimeSpan.FromSeconds(value);
        TimerText.text = "" + time.ToString("mm':'ss"); //Minutos y Segundos
       // TimerText.text = "Tiempo: " + time.ToString("mm':'ss"); //Minutos y Segundos

        if (currentTimer <= 0 && PosicionInstanciaRed.countPubli >= 1 || currentTimer <= 0 && PosicionInstanciaRed.countPubli >= 1 && ActivarEscudoUsuarios.activadosCont >= 1 || currentTimer <= 0 && ActivarEscudoUsuarios.activadosCont >= 1)
        {
            pnlResultados.SetActive(true);
            timeHolder.SetActive(false);
            act_target.SetActive(false);
        }
       
    }

    private void ActGameOver()
    {
        pnlGameOver.SetActive(true);
    }
}
