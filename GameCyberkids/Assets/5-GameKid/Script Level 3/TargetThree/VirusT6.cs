using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusT6 : MonoBehaviour
{
    Vector3 localScaleT6;

    void Start()
    {
        localScaleT6 = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        localScaleT6.x = HealthBarTargetThree.healthAmountT6;
        transform.localScale = localScaleT6;
    }
}
