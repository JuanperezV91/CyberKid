using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamaraActiva : MonoBehaviour
{

    public GameObject CameraAct;
    public GameObject CameraDesct;

    public GameObject Camera1;
    public GameObject Camera2;

    void Start()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(true);

    }

    public void Activar()
    {
        CameraAct.SetActive(true);
        CameraDesct.SetActive(false);
    }

    public void Desactivar()
    {
        CameraAct.SetActive(false);
        CameraDesct.SetActive(true);
    }
}
