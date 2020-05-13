using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VolverMain : MonoBehaviour
{
    

    

    public void CerrarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
       
    }
}
