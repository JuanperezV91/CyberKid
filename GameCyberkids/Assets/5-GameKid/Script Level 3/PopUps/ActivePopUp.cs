using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePopUp : MonoBehaviour
{

    public GameObject popUpEnabled;


    public void ActivarPopUp()
    {
        popUpEnabled.SetActive(true);
    }

    public void DesactivarPopUp()
    {
        popUpEnabled.SetActive(false);
    }
}
