using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackersT3 : MonoBehaviour
{
    Vector3 localScaleT3;

    void Start()
    {
        localScaleT3 = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        localScaleT3.x = HealthTargetHacker.healthT3;
        transform.localScale = localScaleT3;
    }
}