using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPackScript : MonoBehaviour
{
    public AudioSource collisionSound;
    public ParticleSystem effect;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        collisionSound.Play();
        effect.Play();
    }


}
