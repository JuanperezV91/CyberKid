using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusT4 : MonoBehaviour
{
    Vector3 localScaleT4;

    void Start()
    {
        localScaleT4 = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        localScaleT4.x = HealthBarTargetThree.healthAmountT4;
        transform.localScale = localScaleT4;
    }
}
