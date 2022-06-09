using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickLocation : MonoBehaviour
{
    public Collider targetStick;

    public Material mat1;
    public Material mat2;

    public GameManager gm;

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Lever Entered boundary");
        if (collider.gameObject.tag == "InteractiveCube")
        {
            targetStick.transform.GetComponent<MeshRenderer>().material = mat1;
            gm.StickTrueProximity();
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        Debug.Log("Lever exited boundary");
        targetStick.transform.GetComponent<MeshRenderer>().material = mat2;
        gm.StickFalseProximity();
    }
}
