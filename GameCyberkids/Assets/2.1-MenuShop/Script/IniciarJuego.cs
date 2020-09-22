using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class IniciarJuego : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
    }


    public void IniciarMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RegresarPantallaMain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


    public void IniciarJuegoOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void RegresarGameOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        ObjetiveControl.contTargets = 0;
        VirusControl.contVirus = 7;
        HackersControl.contHackers = 4;
    }

    public void IniciarJuegoTwo()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
        ObjetiveControl.contTargets = 0;
        VirusControl.contVirus = 7;
        HackersControl.contHackers = 4;
    }

    public void RegresarGameTwo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        ObjetiveControl.contTargets = 0;
        VirusControl.contVirus = 7;
        HackersControl.contHackers = 4;
    }

    //Other
    public void IniciarJuegoThree()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
        ObjetiveControl.contTargets = 0;
        VirusControl.contVirus = 7;
        HackersControl.contHackers = 4;
    }

    public void RegresarGameThree()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        ObjetiveControl.contTargets = 0;
        VirusControl.contVirus = 7;
        HackersControl.contHackers = 4;

        ControlObjAns.countSeguridad = 0;
        CountValuesObj.countObj = 6;
    }

    public void IniciarJuegoFour()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 13);
        ObjetiveControl.contTargets = 0;
        VirusControl.contVirus = 7;
        HackersControl.contHackers = 4;
    }

    public void RegresarGameFour()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        ObjetiveControl.contTargets = 0;
        VirusControl.contVirus = 7;
        HackersControl.contHackers = 4;
    }

    public void IniciarJuegoFive()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 16);
        ObjetiveControl.contTargets = 0;
        VirusControl.contVirus = 7;
        HackersControl.contHackers = 4;
    }

    public void RegresarGameFive()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        ObjetiveControl.contTargets = 0;
        VirusControl.contVirus = 7;
        HackersControl.contHackers = 4;
    }

    public void IniciarJuegoSix()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 19);
        ObjetiveControl.contTargets = 0;
        VirusControl.contVirus = 7;
        HackersControl.contHackers = 4;
    }

    public void EditarPersonaje()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RegresarMenu() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void EntrarNivel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    
}
