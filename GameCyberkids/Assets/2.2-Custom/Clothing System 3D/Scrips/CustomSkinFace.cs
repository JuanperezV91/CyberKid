using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomSkinFace : MonoBehaviour
{
    public Material[] materialFace;
    static public int xFace;
    Renderer rendFace;

    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = -1;

        xFace = PlayerPrefs.GetInt("skinface", xFace);
        rendFace = GetComponent<Renderer>();
        rendFace.enabled = true;
        rendFace.sharedMaterial = materialFace[xFace];

    }

    void Update()
    {
        rendFace.sharedMaterial = materialFace[xFace];
        PlayerPrefs.SetInt("skinface", xFace);
    }

    public void NextColorFace()
    {

        if (xFace < 3)
        {
            xFace++;
        }
        else
        {
            xFace = 0;
        }
    }
}
