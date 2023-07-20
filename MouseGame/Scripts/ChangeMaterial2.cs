using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial2 : MonoBehaviour
{
    public GameObject cube;

    public Material matUF;

    public Material matDW;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            cube.GetComponent<Renderer>().material = matDW;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            cube.GetComponent<Renderer>().material = matUF;
        }
    }
}
