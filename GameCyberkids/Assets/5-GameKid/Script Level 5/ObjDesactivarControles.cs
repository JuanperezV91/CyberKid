using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDesactivarControles : MonoBehaviour
{
    public GameObject C_obj1;
    public GameObject C_obj2;
    public GameObject C_obj3;
    public GameObject C_obj4;
    public GameObject C_obj5;
    public GameObject C_obj6;

    public void DesactivarControles()
    {
        C_obj1.SetActive(false);
        C_obj2.SetActive(false);
        C_obj3.SetActive(false);
        C_obj4.SetActive(false);
        C_obj5.SetActive(false);
        C_obj6.SetActive(false);

        CountValuesObj.countObj = 6;
    }
}
