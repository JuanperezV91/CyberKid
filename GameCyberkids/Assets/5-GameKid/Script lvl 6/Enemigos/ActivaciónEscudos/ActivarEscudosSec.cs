using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarEscudosSec : MonoBehaviour
{

    public GameObject act_escudo;

    public void activarEscudo()
    {
        act_escudo.SetActive(true);
        Invoke("desactivarEscudo", 5f);
    }

    public void desactivarEscudo()
    {
        act_escudo.SetActive(false);
    }

    void OnMouseDown()
    {
        activarEscudo();
    }
}