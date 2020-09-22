using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProgressBarSecurity : MonoBehaviour
{
    Vector3 localScaleSec;
    private Image _progressBar;


    void Start()
    {
        localScaleSec = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

        localScaleSec.x = ControlObjAns.countSeguridad;
        transform.localScale = localScaleSec;

    }
}
