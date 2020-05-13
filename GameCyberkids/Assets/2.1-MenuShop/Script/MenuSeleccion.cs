using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSeleccion : MonoBehaviour
{
    public GameObject PanelGameOne;
    public GameObject PanelGameTwo;
    public GameObject PanelGameThree;
    public GameObject PanelAyuda;
    public GameObject PanelInventario;


    public void OpenPanelOne()
    {
        if (PanelGameOne != null)
        {
            bool isActive = PanelGameOne.activeSelf;
            PanelGameOne.SetActive(true);
        }
    }

    public void OpenPanelAyuda()
    {
        if (PanelAyuda != null)
        {
            bool isActive = PanelAyuda.activeSelf;
            PanelAyuda.SetActive(true);
        }
    }

    public void ClosePanelAyuda()
    {
       
            PanelAyuda.SetActive(false);
        
    }


    public void OpenPanelInventario()
    {
        if (PanelInventario != null)
        {
            bool isActive = PanelInventario.activeSelf;
            PanelInventario.SetActive(true);
        }
    }

    public void ClosePanelInventario()
    {
        
            PanelInventario.SetActive(false);
        
    }

    public void ClosePanelOne()
    {
        if (PanelGameOne != null)
        {
            PanelGameOne.SetActive(false);
        }
    }

    public void OpenPanelTwo()
    {
        if (PanelGameTwo != null)
        {

            PanelGameTwo.SetActive(true);
        }
    }

    public void ClosePanelTwo()
    {
        if (PanelGameTwo != null)
        {
            PanelGameTwo.SetActive(false);
        }

    }

    public void OpenPanelThree()
    {
        if (PanelGameThree != null)
        {
            bool isActive = PanelGameThree.activeSelf;

            PanelGameThree.SetActive(true);
        }
    }

    public void ClosePanelThree()
    {
        if (PanelGameThree != null)
        {
            PanelGameThree.SetActive(false);
        }

    }

}
