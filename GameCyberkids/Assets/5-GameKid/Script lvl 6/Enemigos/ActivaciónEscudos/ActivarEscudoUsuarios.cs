using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarEscudoUsuarios : MonoBehaviour
{
    public GameObject act_escudo;
    public static int activadosCont;

    void Start()
    {
        activadosCont = 0;
    }

    public void activarEscudo()
    {
        act_escudo.SetActive(true);
        activadosCont += 1;
        Invoke("desactivarEscudo", 9f);
    }

    public void desactivarEscudo()
    {
        act_escudo.SetActive(false);
    }

}
