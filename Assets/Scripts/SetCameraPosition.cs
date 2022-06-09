using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCameraPosition : MonoBehaviour
{
    public Vector3 offsetPosition;

    public GameObject vrCameraPosition;
    public GameObject userCamera;

    private void Start()
    {
        //Set the userCamera to the active camera for the scene
        vrCameraPosition.SetActive(false);
        userCamera.SetActive(true);
    }

    void Update()
    {
        //Each frame change the userCamera position to match the OVRrig Camera plus chosen offset
        userCamera.transform.position = offsetPosition + vrCameraPosition.transform.position;

        //Create new Vector3 from vrCamera rotations and transforms userCamera by these values
        Vector3 newRotation = new Vector3(vrCameraPosition.transform.eulerAngles.x, vrCameraPosition.transform.eulerAngles.y, vrCameraPosition.transform.eulerAngles.z);
        userCamera.transform.eulerAngles = newRotation;
    }
}

