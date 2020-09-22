using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveUsb_PopUp : MonoBehaviour
{
    public GameObject usb_act;
    public GameObject popUp_act;

    void Start()
    {

    }

    public void activarObjetos()
    {
        usb_act.SetActive(true);
        popUp_act.SetActive(true);
    }
}
