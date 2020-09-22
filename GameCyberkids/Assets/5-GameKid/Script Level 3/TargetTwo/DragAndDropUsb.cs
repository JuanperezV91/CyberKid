using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropUsb : MonoBehaviour
{
    public GameObject towerObject;
    public GameObject usbObject;

    public float Distance_;

    public GameObject pnlJuego;
    public GameObject pnlDesactivar;

    public ParticleSystem effect;
    public AudioSource collisionSoundOne;


    void Start()
    {
        bool isActive = true;

    }

    void Update()
    {
      
        Distance_ = Vector3.Distance(towerObject.transform.position, usbObject.transform.position);
        if(Distance_ < 1.5)
        {

            if (usbObject.activeSelf == true)
            {
                DestroyObject(usbObject);
                pnlJuego.SetActive(true);
                pnlDesactivar.SetActive(false);
                effect.Play();
                collisionSoundOne.Play();
            }
        }
    }

   
 

}
