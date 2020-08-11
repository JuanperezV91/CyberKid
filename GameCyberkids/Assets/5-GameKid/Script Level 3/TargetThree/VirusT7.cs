using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusT7 : MonoBehaviour
{
    Vector3 localScaleT3;
    public GameObject four;

    void Start()
    {
        localScaleT3 = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        localScaleT3.x = HealthBarTargetThree.healthAmountT3;
        transform.localScale = localScaleT3;
       
        if (VirusControl.contVirus == 0)
        {
            four.SetActive(true);
        }
    }
}
