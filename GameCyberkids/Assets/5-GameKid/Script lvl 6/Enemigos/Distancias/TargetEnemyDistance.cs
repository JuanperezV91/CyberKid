using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetEnemyDistance : MonoBehaviour
{
    public GameObject target;
    private GameObject[] enemyBlue;
    // private GameObject enemyBlueClone;
    private GameObject[] enemyRed;
    //private GameObject enemyRedClone;

    public float Distance_Blue;
    // public float Distance_BlueClone;
    public float Distance_Red;
    // public float Distance_RedClone;

    // public ParticleSystem effect;

    /* public GameObject pnlJuego;
     public GameObject pnlDesactivar;

     public AudioSource collisionSoundOne;

     */
    void Start()
    {
        // bool isActive = true;




    }

    void Update()
    {
        enemyBlue = GameObject.FindGameObjectsWithTag("BotEnemyBlue");
        //enemyBlueClone = GameObject.Find("BotsEnemyBlue(Clone)");
        enemyRed = GameObject.FindGameObjectsWithTag("BotEnemyRed");
        // enemyRedClone = GameObject.Find("BotsEnemyRed(Clone)");

        for (int i = 0; i < enemyBlue.Length; i++)
        {
            Distance_Blue = Vector3.Distance(target.transform.position, enemyBlue[i].transform.position);
            if (Distance_Blue < 1 && enemyBlue[i])
            {
                DestroyObject(enemyBlue[i]);
            }

            for (int u = 0; u < enemyRed.Length; u++)
            {
                Distance_Red = Vector3.Distance(target.transform.position, enemyRed[u].transform.position);
                if (Distance_Red < 1 && enemyRed[u])
                {
                    DestroyObject(enemyRed[u]);
                }
                /*  Distance_Blue = Vector3.Distance(target.transform.position, enemyBlue.transform.position);
                //  Distance_BlueClone = Vector3.Distance(target.transform.position, enemyBlueClone.transform.position);
                  Distance_Red = Vector3.Distance(target.transform.position, enemyRed.transform.position);
                //  Distance_RedClone = Vector3.Distance(target.transform.position, enemyRedClone.transform.position);

                   if (Distance_Blue < 1 && Distance_BlueClone < 1 && Distance_Red < 1 && Distance_RedClone < 1)
                   {
                       DestroyObject(enemyBlue);
                       DestroyObject(enemyBlueClone);
                       DestroyObject(enemyRed);
                       DestroyObject(enemyRedClone);

                  if (Distance_Blue < 1)        
                      DestroyObject(enemyBlue);

                  if (Distance_BlueClone < 1)
                      DestroyObject(enemyBlueClone);

                  if (Distance_Red < 1)
                      DestroyObject(enemyRed);

                  if (Distance_RedClone < 1)
                      DestroyObject(enemyRedClone);
                  //  if (enemy.activeSelf == true)
                  //  {
                  //      DestroyObject(enemy);
                  //      effect.Play();

                  /*collisionSoundOne.Play();

                  pnlJuego.SetActive(true);
                  pnlDesactivar.SetActive(false);
                  effect.Play();*/
                //   }
            }
        }



    }
}