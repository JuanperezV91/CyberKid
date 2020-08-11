using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HackersControl : MonoBehaviour
{
    public static int contHackers = 4;
    Text hack;

    void Start()
    {
        hack = GetComponent<Text>();
    }

    void Update()
    {
        hack.text = "" + contHackers;
    }

    public void resetContHack()
    {
        contHackers = 4;
    }
}
