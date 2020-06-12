using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneToScene : MonoBehaviour
{

    public void UpdateKid()
    {
        ItemKid.kid = 2;
        PlayerPrefs.SetInt("kid", ItemKid.kid);
    }


    void Start()
    {
        ItemKid.kid = 2;
        PlayerPrefs.SetInt("kid", ItemKid.kid);
    }

    void Update()
    {
        ItemKid.kid = 2;
        PlayerPrefs.SetInt("kid", ItemKid.kid);
    }
}
