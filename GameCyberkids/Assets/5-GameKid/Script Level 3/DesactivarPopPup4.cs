using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarPopPup4 : MonoBehaviour
{
    public GameObject PopupDesactivar;    

    public void DesactivarPopUps()
    {
        PopupDesactivar.SetActive(false);
    }
 
    void OnMouseDown()
    {
        DesactivarPopUps();
    }

}
