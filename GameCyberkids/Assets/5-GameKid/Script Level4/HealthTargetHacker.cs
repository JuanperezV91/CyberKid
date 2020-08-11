using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthTargetHacker : MonoBehaviour
{
    static public float healthT1;
    static public float healthT2;
    static public float healthT3;
    static public float healthT4;
 

    //PopUp Instrucción
    public GameObject popUpFourClose;
    public GameObject popUpHack;
    //Popup Second Mini Game
    public GameObject popUpApps;



    public GameObject g1;
    public GameObject g2;
    public GameObject g3;
    public GameObject g4;
   
    public GameObject targetThree;
    public GameObject HealthIconOne;
    public GameObject HealthIconTwo;
    public GameObject HealthIconThree;
    public GameObject HealthIconFour;
    
    public GameObject HealthLife1;
    public GameObject HealthLife2;
    public GameObject HealthLife3;
    public GameObject HealthLife4;


    public AudioSource audioAtack;
    public AudioSource audioDestroy;

    public GameObject panelWin;
    public GameObject PopUpHackDisabled;
    public int currentWin;



    // Start is called before the first frame update
    void Start()
    {       
        healthT1 = 1;
        healthT2 = 2;
        healthT3 = 2;
        healthT4 = 3;

    }

    // Update is called once per frame
    void Update()
    {

        if (HackersControl.contHackers == 0)
        {
            panelWin.SetActive(true);
            popUpHack.SetActive(false);
            PopUpHackDisabled.SetActive(false);
            popUpApps.SetActive(true);

        }

        if (HackersControl.contHackers == 1)
        {
            popUpHack.SetActive(true);

        }
    }



 
    public void OnClickHacker1()
    {
        healthT1 -= 0.1f;
        audioAtack.Play();
       
        if(healthT1 <= 0){

            g2.SetActive(true);
            Destroy(g1);
            Destroy(HealthLife1);
            Destroy(HealthIconOne);
            audioDestroy.Play();

            HealthIconTwo.SetActive(true);
            HealthLife2.SetActive(true);
   
            Destroy(HealthIconOne);

            HackersControl.contHackers -= 1;
            ScoreScript.scoreValue += 100;
            popUpFourClose.SetActive(false);

        }
    }

    public void OnClickHacker2()
    {
        healthT2 -= 0.1f;
        audioAtack.Play();
        if (healthT2 <= 0)
        {
            Destroy(g2);
            Destroy(HealthLife2);
            Destroy(HealthIconTwo);
            audioDestroy.Play();
            g3.SetActive(true);
            HealthIconThree.SetActive(true);
            HealthLife3.SetActive(true);

            HackersControl.contHackers -= 1;
            ScoreScript.scoreValue += 100;

        }
    }

    public void OnClickHacker3()
    {
        healthT3 -= 0.1f;
        audioAtack.Play();

        if (healthT3 <= 0)
        {
            Destroy(g3);
            Destroy(HealthLife3);
            Destroy(HealthIconThree);
            audioDestroy.Play();

            g4.SetActive(true);
            HealthIconFour.SetActive(true);
            HealthLife4.SetActive(true);


            HackersControl.contHackers -= 1;
            ScoreScript.scoreValue += 100;

        }
    }

    public void OnClickHacker4()
    {
        healthT4 -= 0.1f;
        audioAtack.Play();

        if (healthT4 <= 0)
        {
            Destroy(g4);
            Destroy(HealthIconFour);
            Destroy(HealthLife4);
            Destroy(HealthIconFour);

            audioDestroy.Play();

            HackersControl.contHackers -= 1;
            ScoreScript.scoreValue += 100;
            popUpHack.SetActive(false);

        }
    }
}