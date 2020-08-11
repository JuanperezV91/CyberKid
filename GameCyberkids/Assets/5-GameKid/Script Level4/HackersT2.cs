using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackersT2 : MonoBehaviour
{
    Vector3 localScaleT2;

    void Start()
    {
        localScaleT2 = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        localScaleT2.x = HealthTargetHacker.healthT2;
        transform.localScale = localScaleT2;
    }
}