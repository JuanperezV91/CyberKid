using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsControl : MonoBehaviour
{
    public GameObject[] arrowsIc;

    public void activarIconos()
    {
        for (int i = 0; i < arrowsIc.Length; i++)
        {

            arrowsIc[i].SetActive(true);

        }
    }


    public void desactivarIconos()
    {
        for (int i = 0; i < arrowsIc.Length; i++)
        {

            arrowsIc[i].SetActive(false);

        }
    }

}
    
