using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusT2 : MonoBehaviour
{
    Vector3 localScaleT2;

    void Start()
    {
        localScaleT2 = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        localScaleT2.x = HealthBarTargetThree.healthAmountT2;
        transform.localScale = localScaleT2;
    }
}
