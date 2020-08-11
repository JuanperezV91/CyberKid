using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class ThirdPersonInput : MonoBehaviour
{
    public FixedJoystick leftJoystick;
   // public FixedButton Button;
    protected SimpleCharacterControlFree Control;

    void Start()
    {
        Control = GetComponent<SimpleCharacterControlFree>();
    }

    // Update is called once per frame
    void Update()
    {
        Control.Hinput = leftJoystick.Horizontal;
        Control.Vinput = leftJoystick.Vertical;

    }
}
