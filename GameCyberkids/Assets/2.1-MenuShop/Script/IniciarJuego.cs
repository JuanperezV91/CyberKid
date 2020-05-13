using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class IniciarJuego : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //CyberWorld
    public void IniciarJuegoOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //DataKidsRecovery
    public void IniciarJuegoTwo()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }

    //Other
    public void IniciarJuegoThree()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);

    }

    public void EditarPersonaje()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);

    }
}
