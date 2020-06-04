using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragEmailDrop : MonoBehaviour
{
    public GameObject okVector, trashVector, email1, email2, email3, email4, email5, PanelWin, PanelGame;
    

    Vector2 posicionOkVector, posicionTrashVector, posicionEmail1, posicionEmail2, posicionEmail3, posicionEmail4,posicionEmail5;
    bool email1Correcto, email1Incorrecto, email2Correcto, email2Incorrecto, email3Correcto, email3Incorrecto, email4Correcto, email4Incorrecto, email5Correcto, email5Incorrecto = false;

    public AudioSource source;
    public AudioClip[] correcto;
    public AudioClip incorrecto;

    


    // Start is called before the first frame update
    public void Start()
    {
        posicionOkVector = okVector.transform.position;
        posicionTrashVector = trashVector.transform.position;
        posicionEmail1 = email1.transform.position;
        posicionEmail2 = email2.transform.position;
        posicionEmail3 = email3.transform.position;
        posicionEmail4 = email4.transform.position;
        posicionEmail5 = email5.transform.position;
        //ScoreCounter
     
    }

    


    //Drag

    public void DragEmail1()
    {
        email1.transform.position = Input.mousePosition;
    }

    public void DragEmail2()
    {
        email2.transform.position = Input.mousePosition;
    }

    public void DragEmail3()
    {
        email3.transform.position = Input.mousePosition;
    }

    public void DragEmail4()
    {
        email4.transform.position = Input.mousePosition;
    }

    public void DragEmail5()
    {
        email5.transform.position = Input.mousePosition;
    }

    //Metodos Drop/Soltar

    public void DropEmail1()
    {
        float Distance = Vector3.Distance(email1.transform.position, trashVector.transform.position);
        if (Distance < 50)
        {
            email1.transform.position = trashVector.transform.position;
            source.clip = correcto[Random.Range(0, correcto.Length)];
            source.Play();
            email1Correcto = true;
            email1.SetActive(false);
            email2.SetActive(true);

            //ScoreCounter
            ScoreScript.scoreValue += 100;
        }
        else
        {
            email1.transform.position = posicionEmail1;
            source.clip = incorrecto;
            source.Play();
        }
    }

    public void DropEmail2()
    {
        float Distance = Vector3.Distance(email2.transform.position, okVector.transform.position);
        if (Distance < 50)
        {
            email2.transform.position = okVector.transform.position;
            source.clip = correcto[Random.Range(0, correcto.Length)];
            source.Play();
            email2Correcto = true;
            email2.SetActive(false);
            email3.SetActive(true);

            //ScoreCounter
            ScoreScript.scoreValue += 100;
        }
        else
        {
            email2.transform.position = posicionEmail2;
            source.clip = incorrecto;
            source.Play();
        }

    }

    public void DropEmail3()
    {
        float Distance = Vector3.Distance(email3.transform.position, trashVector.transform.position);
        if (Distance < 50)
        {
            email3.transform.position = trashVector.transform.position;
            source.clip = correcto[Random.Range(0, correcto.Length)];
            source.Play();
            email3Correcto = true;
            email3.SetActive(false);
            email4.SetActive(true);

            //ScoreCounter
            ScoreScript.scoreValue += 100;
        }
        else
        {
            email3.transform.position = posicionEmail3;
            source.clip = incorrecto;
            source.Play();
        }
    }

    public void DropEmail4()
    {
        float Distance = Vector3.Distance(email4.transform.position, okVector.transform.position);
        if (Distance < 50)
        {
            email4.transform.position = okVector.transform.position;
            source.clip = correcto[Random.Range(0, correcto.Length)];
            source.Play();
            email4Correcto = true;
            email4.SetActive(false);
            email5.SetActive(true);

            //ScoreCounter
            ScoreScript.scoreValue += 100;
        }
        else
        {
            email4.transform.position = posicionEmail4;
            source.clip = incorrecto;
            source.Play();
        }
    }

    public void DropEmail5()
    {
        float Distance = Vector3.Distance(email5.transform.position, trashVector.transform.position);
        if (Distance < 50)
        {
            email5.transform.position = trashVector.transform.position;
            source.clip = correcto[Random.Range(0, correcto.Length)];
            source.Play();
            email5Correcto = true;
            email5.SetActive(false);

            //ScoreCounter
            ScoreScript.scoreValue += 100;
        }
        else
        {
            email5.transform.position = posicionEmail5;
            source.clip = incorrecto;
            source.Play();
        }
    }




    void Update()
    {
        if (email1Correcto && email2Correcto && email3Correcto && email4Correcto && email5Correcto)
        {
            PanelWin.SetActive(true);
        }

    }

}
