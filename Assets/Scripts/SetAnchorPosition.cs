using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnchorPosition : MonoBehaviour
{
    public Vector3 updatePosition;
    
    public float xRotation;
    public float yRotation;
    public float zRotation;

    // Update is called once per frame
    void Update()
    {
        this.transform.position += updatePosition;
        transform.Rotate(xRotation, yRotation, zRotation, Space.Self);
    }
}
