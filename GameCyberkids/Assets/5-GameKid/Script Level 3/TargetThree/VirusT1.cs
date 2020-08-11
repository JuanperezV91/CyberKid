using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusT1 : MonoBehaviour
{
    Vector3 localScaleT1;

    void Start()
    {
        localScaleT1 = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        localScaleT1.x = HealthBarTargetThree.healthAmountT1;
        transform.localScale = localScaleT1;
    }
}
