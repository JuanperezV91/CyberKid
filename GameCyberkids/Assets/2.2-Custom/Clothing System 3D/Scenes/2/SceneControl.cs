using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour
{
    public GameObject _cyberkid;
    public GameObject elec01;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        _cyberkid = GameObject.FindGameObjectWithTag("Cyberkid");
        if(_cyberkid == true)
        {

        }
    }
}
