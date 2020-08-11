using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarTargetThree : MonoBehaviour
{
    static public float healthAmountT3;
    static public float healthAmountT1;
    static public float healthAmountT2;
    static public float healthAmount3;
    static public float healthAmountT4;
    static public float healthAmountT5;
    static public float healthAmountT6;

    public GameObject popUpFourClose;



    public GameObject g1;
    public GameObject g2;
    public GameObject g3;
    public GameObject g4;
    public GameObject g5;
    public GameObject g6;
    public GameObject g7;
    public GameObject targetFour;
    public GameObject HealthIconOne;
    public GameObject HealthIconTwo;
    public GameObject HealthIconThree;
    public GameObject HealthIconFour;
    public GameObject HealthIconFive;
    public GameObject HealthIconSix;
    public GameObject HealthIconSV;

    public AudioSource audioAtack;
    public AudioSource audioDestroy;

    public GameObject panelWin;
    public int currentWin;



    // Start is called before the first frame update
    void Start()
    {
        healthAmountT3 = 1;
        healthAmountT1 = 2;
        healthAmountT2 = 2;
        healthAmount3 = 1;
        healthAmountT4 = 1;
        healthAmountT5 = 1;
        healthAmountT6 = 1;

    }

    // Update is called once per frame
    void Update()
    {
           
        if (VirusControl.contVirus == 0)
        {
            targetFour.SetActive(true);
            panelWin.SetActive(true);         

        }
    }

    

        public void OnClickEnemy()
    {
        healthAmountT3 -= 0.1f;
        audioAtack.Play();

        if (healthAmountT3 <= 0)
        {
            Destroy(g7);
            Destroy(HealthIconSV);
            audioDestroy.Play();

            VirusControl.contVirus -= 1;
            ScoreScript.scoreValue += 100;
            popUpFourClose.SetActive(false);

        }
    }

    public void OnClickEnemy1()
    {
        healthAmountT1 -= 0.1f;
        audioAtack.Play();
        if (healthAmountT1 <= 0)
        {
            Destroy(g1);
            audioDestroy.Play();
            Destroy(HealthIconOne);

            VirusControl.contVirus -= 1;
            ScoreScript.scoreValue += 100;
            popUpFourClose.SetActive(false);

        }
    }

    public void OnClickEnemy2()
    {
        healthAmountT2 -= 0.1f;
        audioAtack.Play();
        if (healthAmountT2 <= 0)
        {
            Destroy(g2);
            audioDestroy.Play();
            Destroy(HealthIconTwo);

            VirusControl.contVirus -= 1;
            ScoreScript.scoreValue += 100;
            popUpFourClose.SetActive(false);

        }
    }

    public void OnClickEnemy3()
    {
        healthAmount3 -= 0.1f;
        audioAtack.Play();

        if (healthAmount3 <= 0)
        {
            Destroy(g3);
            Destroy(HealthIconThree);

            audioDestroy.Play();

            VirusControl.contVirus -= 1;
            ScoreScript.scoreValue += 100;
            popUpFourClose.SetActive(false);


        }
    }

    public void OnClickEnemy4()
    {
        healthAmountT4 -= 0.1f;
        audioAtack.Play();

        if (healthAmountT4 <= 0)
        {
            Destroy(g4);
            Destroy(HealthIconFour);

            audioDestroy.Play();

            VirusControl.contVirus -= 1;
            ScoreScript.scoreValue += 100;
            popUpFourClose.SetActive(false);

        }
    }

    public void OnClickEnemy5()
    {
        healthAmountT5 -= 0.1f;
        audioAtack.Play();

        if (healthAmountT5 <= 0)
        {
            Destroy(g5);
            Destroy(HealthIconFive);
            audioDestroy.Play();

            VirusControl.contVirus -= 1;
            ScoreScript.scoreValue += 100;
            popUpFourClose.SetActive(false);

        }
    }

    public void OnClickEnemy6()
    {
        healthAmountT6 -= 0.1f;
        audioAtack.Play();

        if (healthAmountT6 <= 0)
        {
            Destroy(g6);
            Destroy(HealthIconSix);
            audioDestroy.Play();

            VirusControl.contVirus -= 1;
            ScoreScript.scoreValue += 100;
            popUpFourClose.SetActive(false);

        }

    }

}
