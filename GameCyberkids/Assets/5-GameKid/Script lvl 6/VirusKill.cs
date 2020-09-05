using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusKill : MonoBehaviour
{
    public AudioSource collisionSound;
    public ParticleSystem effect;
    public GameObject virus;


    void OnMouseDown()
    {
        effect.Play();
        ScoreScript.scoreValue += 100;
        collisionSound.Play();

        virus.SetActive(false);

        
    }
}