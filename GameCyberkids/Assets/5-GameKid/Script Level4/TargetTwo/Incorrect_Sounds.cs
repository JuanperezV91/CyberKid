using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incorrect_Sounds : MonoBehaviour
{
    public AudioClip incorrecto;
    public AudioSource source;

    public void audioIncorrecto()
    {
        source.clip = incorrecto;


        source.Play();
    }

}
