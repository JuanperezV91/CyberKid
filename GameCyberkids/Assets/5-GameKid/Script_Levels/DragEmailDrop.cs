using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragEmailDrop : MonoBehaviour
{
    public GameObject okVector, trashVector, email1, email2, email3, email4, email5, PanelWin, PanelGame;
    static public Vector2 posicionIniEm1;
    static public Vector2 posicionIniEm2;
    static public Vector2 posicionIniEm3;
    static public Vector2 posicionIniEm4;
    static public Vector2 posicionIniEm5;

    public GameObject popUpOne;
    public GameObject popUpTwo;
    public GameObject popUpThree;

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

        posicionIniEm1 = posicionEmail1;
        posicionIniEm2 = posicionEmail2;
        posicionIniEm3 = posicionEmail3;
        posicionIniEm4 = posicionEmail4;
        posicionIniEm5 = posicionEmail5;

        popUpOne.SetActive(true);
        popUpTwo.SetActive(false);
        popUpThree.SetActive(false);
        //ScoreCounter

    }




    //Drag

    public void DragEmail1()
    {
        email1.transform.position = Input.mousePosition;
        email1.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

    }

    public void DragEmail2()
    {
        email2.transform.position = Input.mousePosition;
        email2.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

    }

    public void DragEmail3()
    {
        email3.transform.position = Input.mousePosition;
        email3.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

    }

    public void DragEmail4()
    {
        email4.transform.position = Input.mousePosition;
        email4.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

    }

    public void DragEmail5()
    {
        email5.transform.position = Input.mousePosition;
        email5.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

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

            //PopUp

            popUpOne.SetActive(false);
            popUpTwo.SetActive(true);
            popUpThree.SetActive(false);

            //ScoreCounter
            ScoreScript.scoreValue += 100;
            MailControl.contMails += 1;
        }
        else
        {
            email1.transform.localScale = new Vector3(7.9f, 7.9f, 7.9f);

            email1.transform.position = posicionIniEm1;
            source.clip = incorrecto;


            source.Play();
        }

        email1.transform.position = posicionIniEm1;

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

            //PopUp

            popUpOne.SetActive(false);
            popUpTwo.SetActive(false);
            popUpThree.SetActive(true);

            //ScoreCounter
            ScoreScript.scoreValue += 100;
            MailControl.contMails += 1;

        }
        else
        {
            email2.transform.localScale = new Vector3(7.9f, 7.9f, 7.9f);

            email2.transform.position = posicionIniEm2;
            source.clip = incorrecto;

            source.Play();
        }
        email2.transform.position = posicionIniEm2;


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
            MailControl.contMails += 1;

        }
        else
        {
            email3.transform.localScale = new Vector3(7.9f, 7.9f, 7.9f);
            email3.transform.position = posicionIniEm3;
            source.clip = incorrecto;

            source.Play();
        }
        email3.transform.position = posicionIniEm3;

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

            //PopUp
            popUpThree.SetActive(false);


            //ScoreCounter
            ScoreScript.scoreValue += 100;
            MailControl.contMails += 1;

        }
        else
        {
            email4.transform.localScale = new Vector3(7.9f, 7.9f, 7.9f);
            email4.transform.position = posicionIniEm4;
            source.clip = incorrecto;

            source.Play();
        }
        email4.transform.position = posicionIniEm4;

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
            MailControl.contMails += 1;

        }
        else
        {
            email5.transform.localScale = new Vector3(7.9f, 7.9f, 7.9f);
            email5.transform.position = posicionIniEm5;
            source.clip = incorrecto;

            source.Play();
        }
        email5.transform.position = posicionIniEm5;

    }




    void Update()
    {
        if (email1Correcto && email2Correcto && email3Correcto && email4Correcto && email5Correcto)
        {
            PanelWin.SetActive(true);
            MailControl.contMails = 0;

        }

    }

}
