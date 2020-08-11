using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusT5 : MonoBehaviour
{
    Vector3 localScaleT5;

    void Start()
    {
        localScaleT5 = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        localScaleT5.x = HealthBarTargetThree.healthAmountT5;
        transform.localScale = localScaleT5;
    }
}
