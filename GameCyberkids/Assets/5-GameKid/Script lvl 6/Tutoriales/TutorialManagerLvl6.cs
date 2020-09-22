using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManagerLvl6 : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;
    public static int popUpCount;

    void Start()
    {
        popUpCount = 0;
    }

    void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if(i == popUpIndex)
            {
                popUps[i].SetActive(true);
            }else
            {
                popUps[i].SetActive(false);
            }
        }

        if(popUpIndex == 0)
        {
            popUpIndex = popUpCount;
        }else
         if (popUpIndex == 1)
        {
            popUpIndex = popUpCount;
        }
        else
         if (popUpIndex == 2)
        {
            popUpIndex = popUpCount;
        }
        else
           if (popUpIndex == 3)
        {
            popUpIndex = popUpCount;
        }
        else
           if (popUpIndex == 4)
        {
            popUpIndex = popUpCount;
        }
        else
           if (popUpIndex == 5)
        {
            popUpIndex = popUpCount;
        }
        else
           if (popUpIndex == 6)
        {
            popUpIndex = popUpCount;
        }
        else
           if (popUpIndex == 7)
        {
            popUpIndex = popUpCount;
        }
        else
           if (popUpIndex == 8)
        {
            popUpIndex = popUpCount;
        }
        else
           if (popUpIndex == 9)
        {
            popUpIndex = popUpCount;
        }
        else
           if (popUpIndex == 10)
        {
            popUpIndex = popUpCount;
        }




    }

    public void CountP()
    {
        popUpCount++;
    }
}
