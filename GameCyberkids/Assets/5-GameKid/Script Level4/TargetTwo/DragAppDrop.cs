using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragAppDrop : MonoBehaviour
{

    public GameObject trashVector, app1, app2, app3, PanelWin, PanelGame;
    static public Vector2 posicionIniapp1;
    static public Vector2 posicionIniapp2;
    static public Vector2 posicionIniapp3;

    public GameObject popUpApp;


    Vector2 posicionTrashVector, posicionApp1, posicionApp2, posicionApp3;
    bool app1Correcto, app1Incorrecto, app2Correcto, app2Incorrecto, app3Correcto, app3Incorrecto = false;

    public AudioSource source;
    public AudioClip[] correcto;
    public AudioClip incorrecto;


    // Start is called before the first frame update
    public void Start()
    {
        posicionTrashVector = trashVector.transform.position;
        posicionApp1 = app1.transform.position;
        posicionApp2 = app2.transform.position;
        posicionApp3 = app3.transform.position;


        posicionIniapp1 = posicionApp1;
        posicionIniapp2 = posicionApp2;
        posicionIniapp3 = posicionApp3;
       

        //ScoreCounter
    }

    //Metodos Drag

    public void DragApp1()
    {
        app1.transform.position = Input.mousePosition;
       // app1.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

    }

    public void DragApp2()
    {
        app2.transform.position = Input.mousePosition;
       // app2.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

    }

    public void DragApp3()
    {
        app3.transform.position = Input.mousePosition;
       // app3.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);

    }

   

    //Metodos Drop/Soltar

    public void DropApp1()
    {
        float Distance = Vector3.Distance(app1.transform.position, trashVector.transform.position);

        if (Distance < 50)
        {
            app1.transform.position = trashVector.transform.position;
            source.clip = correcto[Random.Range(0, correcto.Length)];
            source.Play();
            app1Correcto = true;
            app1.SetActive(false);
            popUpApp.SetActive(false);

            //PopUp

            // popUpOne.SetActive(false);


            //ScoreCounter
            ScoreScript.scoreValue += 100;
            //MailControl.contMails += 1;
        }
        else
        {
            app1.transform.localScale = new Vector3(7.9f, 7.9f, 7.9f);

            app1.transform.position = posicionIniapp1;
            source.clip = incorrecto;


            source.Play();
        }

        app1.transform.position = posicionIniapp1;

    }

    public void DropEmail2()
    {
        float Distance = Vector3.Distance(app2.transform.position, trashVector.transform.position);

        if (Distance < 50)
        {
            app2.transform.position = trashVector.transform.position;
            source.clip = correcto[Random.Range(0, correcto.Length)];
            source.Play();
            app2Correcto = true;
            app2.SetActive(false);

            //ScoreCounter
            ScoreScript.scoreValue += 100;
           // MailControl.contMails += 1;
        }
        else
        {
            app2.transform.localScale = new Vector3(7.9f, 7.9f, 7.9f);

            app2.transform.position = posicionIniapp2;
            source.clip = incorrecto;


            source.Play();
        }

        app2.transform.position = posicionIniapp2;

    }

    public void DropEmail3()
    {
        float Distance = Vector3.Distance(app3.transform.position, trashVector.transform.position);

        if (Distance < 50)
        {
            app3.transform.position = trashVector.transform.position;
            source.clip = correcto[Random.Range(0, correcto.Length)];
            source.Play();
            app3Correcto = true;
            app3.SetActive(false);

            //ScoreCounter
            ScoreScript.scoreValue += 100;
           // MailControl.contMails += 1;
        }
        else
        {
            app3.transform.localScale = new Vector3(7.9f, 7.9f, 7.9f);

            app2.transform.position = posicionIniapp2;
            source.clip = incorrecto;


            source.Play();
        }

        app2.transform.position = posicionIniapp2;

    }


    void Update()
    {
        if (app1Correcto && app2Correcto && app3Correcto)
        {
            PanelWin.SetActive(true);
        }

    }

}
