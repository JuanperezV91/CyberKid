using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComenzarJuegoUSB : MonoBehaviour
{
    public GameObject usb_des;
    public GameObject usb_act;
    public GameObject pnlObjetivo;
    public GameObject popup_des;

    public GameObject button_des;
    public GameObject arrowIcon_des;


    public void comenzarJuego()
    {
        DestroyObject(usb_des);
        DestroyObject(button_des);
        DestroyObject(arrowIcon_des);
        popup_des.SetActive(false);

        //  usb_des.SetActive(false);
        usb_act.SetActive(true);
        pnlObjetivo.SetActive(true);

     //   button_des.SetActive(false);
       // arrowIcon_des.SetActive(false);


    }

  

}
