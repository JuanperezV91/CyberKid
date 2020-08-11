using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    
    public Transform[] vistasCam;
    public float transitionVelocidad;
    Transform vistaActual;
    static public int currentCam;
    static public int startCam;


    // Start is called before the first frame update
    void Start()
    {
        startCam = 0;
    }

    void Update()
    {
        vistaActual = vistasCam[startCam];          
    }    

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, vistaActual.position, Time.deltaTime * transitionVelocidad);

        Vector3 currentAngle = new Vector3(
            Mathf.LerpAngle(transform.rotation.eulerAngles.x, vistaActual.transform.rotation.eulerAngles.x, Time.deltaTime * transitionVelocidad),
            Mathf.LerpAngle(transform.rotation.eulerAngles.y, vistaActual.transform.rotation.eulerAngles.y, Time.deltaTime * transitionVelocidad),
            Mathf.LerpAngle(transform.rotation.eulerAngles.z, vistaActual.transform.rotation.eulerAngles.z, Time.deltaTime * transitionVelocidad));
        transform.eulerAngles = currentAngle;
        
    }
    
    public void CamOne()
    {       
        currentCam = 0;
        startCam = currentCam;
    }

    public void CamTwo()
    {
        currentCam = 1;
        startCam = currentCam;
    }


    /*
public Transform cameraTargetOne;
public Transform cameraTargetTwo;
public float sSpeed = 1.0f;
public Vector3 dist;
public Transform lookTarget;
private Transform cameraTargets;

private int currentTarget;

void Start()
{
    currentTarget = 1;
    SetCameraTarget(currentTarget);
}

void Update()
{

}

void FixedUpdate()
{
    Vector3 dPos = cameraTargets.position + dist;
    Vector3 sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
    transform.position = sPos;
    transform.LookAt(lookTarget.position);
}

public void SetCameraTarget(int num)
{
    switch (num)
    {
        case 1:
            cameraTargets = cameraTargetOne.transform;
            break;
        case 2:
            cameraTargets = cameraTargetTwo.transform;
            break;
    }
}

public void SwitchCamera()
{
    if (currentTarget < 2)
        currentTarget++;
    else
        currentTarget = 1;
    SetCameraTarget(currentTarget);
}
    */

}
