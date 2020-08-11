using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleListT2 : MonoBehaviour
{
    public static List<ET2> ShuffleListT2Items<ET2>(List<ET2> inputList)
    {
        List<ET2> originalListT2 = new List<ET2>();
        originalListT2.AddRange(inputList);
        List<ET2> randomListT2 = new List<ET2>();

        System.Random r = new System.Random();
        int randomIndex = 0;
        while (originalListT2.Count > 0)
        {
            randomIndex = r.Next(0, originalListT2.Count); //Choose a random object in the list
            randomListT2.Add(originalListT2[randomIndex]); //add it to the new, random list
            originalListT2.RemoveAt(randomIndex); //remove to avoid duplicates
        }

        return randomListT2; //return the new random list
    }
   
}
