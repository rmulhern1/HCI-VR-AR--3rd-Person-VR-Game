using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorLocationRotation : MonoBehaviour
{
    public GameObject vrCamera;
    public GameObject currentCamera;

    public Vector3 offset;

    private float xRotation;
    private float yRotation;
    private float zRotation;

    public float xRotationOffset;
    public float yRotationOffset;
    public float zRotationOffset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Switches camera
        vrCamera.SetActive(false);
        currentCamera.SetActive(true);

        //xRotation = xRotationOffset + this.transform.rotation.x;
        //yRotation = yRotationOffset + this.transform.rotation.y;
        //zRotation = zRotationOffset + this.transform.rotation.z;

        this.transform.position = vrCamera.transform.position + offset;
        this.transform.Rotate(xRotation, yRotation, zRotation, Space.Self);

    }
}
