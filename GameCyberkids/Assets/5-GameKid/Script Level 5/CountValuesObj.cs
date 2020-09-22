using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountValuesObj : MonoBehaviour
{
    public static int countObj;
     
    void Start()
    {
        countObj = 6;
    }

    void Update()
    {
        if (countObj == 3 && ControlObjAns.countSeguridad == 3)
        {
            ControlCamara.startCam = 0;
        }
       
    }
  
}
