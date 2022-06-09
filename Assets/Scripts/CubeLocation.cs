using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLocation : MonoBehaviour
{
    public Collider targetCube;

    public Material mat1;
    public Material mat2;

    public GameManager gm;

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "InteractiveCube")
        {
            targetCube.transform.GetComponent<MeshRenderer>().material = mat1;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Cube Entered boundary");
        if (collider.gameObject.tag == "InteractiveCube") {
            gm.addCubeProximity();
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        Debug.Log("Cube exited boundary");
        targetCube.transform.GetComponent<MeshRenderer>().material = mat2;
        gm.minusCubeProximity();
    }
}
