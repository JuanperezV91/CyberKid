using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpUSB : MonoBehaviour
{
    public GameObject kidObject;
    public GameObject usbObject;
    public GameObject arrowIcon;
    public GameObject buttonDragObject;


    public float Distance_;
   // public AudioSource collisionSoundOne;

    void Start()
    {

    }

    void Update()
    {
        Distance_ = Vector3.Distance(kidObject.transform.position, usbObject.transform.position);
        if (Distance_ < 1)
        {
            if (usbObject.activeSelf == true)
            {
              arrowIcon.SetActive(true);
              buttonDragObject.SetActive(true);
            }              
        }
        else
        {
            arrowIcon.SetActive(false);
            buttonDragObject.SetActive(false);
        }
    }



}
