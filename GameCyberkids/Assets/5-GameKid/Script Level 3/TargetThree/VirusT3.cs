using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusT3 : MonoBehaviour
{
    Vector3 localScale3;

    void Start()
    {
        localScale3 = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        localScale3.x = HealthBarTargetThree.healthAmount3;
        transform.localScale = localScale3;
    }
}
