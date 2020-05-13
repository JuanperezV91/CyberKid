using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{

    public GameObject Virus, antivirus, Malware, mouse, MalwareBack, antivirusBack, VirusBack, MouseBack;
    
    Vector2 posicionVirus, posicionAntivirus, posicionMalware, posicionMouse;
    bool virusCorrecto, antivirusCorrect, malwareCorrecto, mouseCorrecto = false;

    public AudioSource source;
    public AudioClip[] correcto;
    public AudioClip incorrecto;

    // Start is called before the first frame update
    public void Start()
    {
        posicionVirus = Virus.transform.position;
        posicionAntivirus = antivirus.transform.position;
        posicionMalware = Malware.transform.position;
        posicionMouse = mouse.transform.position;
    }

    
    //Drag
    public void DragVirus()
    {
        Virus.transform.position = Input.mousePosition;
    }

    //Drag
    public void DragAntiVirus()
    {
        antivirus.transform.position = Input.mousePosition;
    }


    //Drag
    public void DragMouse()
    {
        mouse.transform.position = Input.mousePosition;
    }


    //Drag
    public void DragMalware()
    {
        Malware.transform.position = Input.mousePosition;
    }
    //Metodos Drop/Soltar

    public void DropVirus()
    {
        float Distance = Vector3.Distance(Virus.transform.position, VirusBack.transform.position);
        if(Distance < 50)
        {
            Virus.transform.position = VirusBack.transform.position;
            source.clip = correcto[Random.Range(0, correcto.Length)];
            source.Play();
            virusCorrecto = true;
        }
        else
        {
            Virus.transform.position = posicionVirus;
            source.clip = incorrecto;
            source.Play();
        }
    }

   
    public void DropAntiVirus()
    {
        float Distance = Vector3.Distance(antivirus.transform.position, antivirusBack.transform.position);
        if (Distance < 50)
        {
            antivirus.transform.position = antivirusBack.transform.position;
            source.clip = correcto[Random.Range(0, correcto.Length)];
            source.Play();
            antivirusCorrect = true;
        }
        else
        {
            antivirus.transform.position = posicionAntivirus;
            source.clip = incorrecto;
            source.Play();
        }
    }

    public void DropMalware()
    {
        float Distance = Vector3.Distance(Malware.transform.position, MalwareBack.transform.position);
        if (Distance < 50)
        {
            Malware.transform.position = MalwareBack.transform.position;
            source.clip = correcto[Random.Range(0, correcto.Length)];
            source.Play();
            malwareCorrecto = true;
        }
        else
        {
            Malware.transform.position = posicionMalware;
            source.clip = incorrecto;
            source.Play();
        }
    }

    public void DropMouse()
    {
        float Distance = Vector3.Distance(mouse.transform.position, MouseBack.transform.position);
        if (Distance < 50)
        {
            mouse.transform.position = MouseBack.transform.position;
            source.clip = correcto[Random.Range(0, correcto.Length)];
            source.Play();
            mouseCorrecto = true;
        }
        else
        {
            mouse.transform.position = posicionMouse;
            source.clip = incorrecto;
            source.Play();
        }

    }

    void Update()
    {
        if(virusCorrecto && antivirusCorrect && malwareCorrecto && mouseCorrecto)
        {
            Debug.Log("Felicidades!! Has ganado");
        }
    }

    


}
