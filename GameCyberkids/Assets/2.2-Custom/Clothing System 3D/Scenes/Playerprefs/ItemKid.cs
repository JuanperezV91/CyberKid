using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemKid : MonoBehaviour
{
    public GameObject _Kid;
   /* public GameObject _glass;
    public GameObject _Glass_frame;
    public GameObject _pant;
    public GameObject _tshirt;*/

    public static int kid;
   /* public static int glass;
    public static int glass_frame;
    public static int pant;
    public static int tshirt;*/

    void Start()
    {
        kid = PlayerPrefs.GetInt("kid", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (kid == 1)
        {
            _Kid.SetActive(false);
        }
        else
        {
            _Kid.SetActive(true);
        }
    }
}
