using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropObjects : MonoBehaviour
{

    public GameObject bagTarget;
    Vector2 DistBagTarget;
    Vector2 DistGameObject;
    public ParticleSystem effect;
    public AudioSource collisionSoundOne;
    static public int countObjects;
    public GameObject targetThreeActive;
    public GameObject HandPointFalse;

    //PopUp
    public GameObject popUpClose;

    private Vector3 mOffset;
    private float mZCoord;


    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }
    
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    public void activeTargetThree()
    {
        targetThreeActive.SetActive(true);
        countObjects = 0;
    }
    void OnMouseDrag()
    {
       // DistBagTarget = bagTarget.transform.position;
       // DistGameObject = gameObject.transform.position;
        float disTarget = Vector3.Distance(gameObject.transform.position, bagTarget.transform.position);

        transform.position = GetMouseWorldPos() + mOffset;

        if (disTarget < 1)
      // if(DistBagTarget == DistGameObject)
        {
            gameObject.transform.position = bagTarget.transform.position;
            DestroyObject(gameObject);
            ScoreScript.scoreValue += 50;

            //ParticleSystem
            effect.Play();
            collisionSoundOne.Play();
            countObjects += 1;

            //PopUp
            popUpClose.SetActive(false);

            if (countObjects == 4)
            {
                activeTargetThree();
                ControlCamara.startCam = 1;
                HandPointFalse.SetActive(false);

            }

            //  source.clip = correcto[Random.Range(0, correcto.Length)];
            //  source.Play();
            //  email1Correcto = true;
            //  email1.SetActive(false);
            //  email2.SetActive(true);

            //ScoreCounter
            //  ScoreScript.scoreValue += 100;
        }
        /*   else
           {
               //  email1.transform.localScale = new Vector3(7.9f, 7.9f, 7.9f);
               gameObject.transform.position = posicionIniObject;
             //  email1.transform.position = posicionIniEm1;
             //  source.clip = incorrecto;


               //  source.Play();
           }

           email1.transform.position = posicionIniEm1;*/
    }  

}
