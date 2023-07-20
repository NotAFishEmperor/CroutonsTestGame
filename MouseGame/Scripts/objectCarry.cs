using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectCarry : MonoBehaviour
{
    bool objectTrigger = false;
    public Transform teleportTarget;


    void OnTriggerEnter (Collider objectCarry)
    {
        if (objectCarry.gameObject.tag == "Player")
        {
            Debug.Log("True");
            objectTrigger = true;
        }
    }
    
    void OnTriggerExit (Collider objectCarry)
    {
        if (objectCarry.gameObject.tag == "Player")
        {
            objectTrigger = false;
        }
    }

    void Update()
    {
        if (objectTrigger == true)
        {
            if( Input.GetButton("Fire1") ) {
                this.gameObject.transform.position = teleportTarget.transform.position;
            }

        }
    }
}
