using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectGrabable : MonoBehaviour
{
    private Rigidbody objectRigidbody;
    private Transform objectGrabPointTransform;
    // Start is called before the first frame update
    public void Awake(){
        objectRigidbody = GetComponent<Rigidbody>();
    }
    public void Grab(Transform objectGrabPointTransform){
            this.objectGrabPointTransform = objectGrabPointTransform;
            objectRigidbody.useGravity = false;
                                    Debug.Log("grabbed2");

    }

    public void Drop(){
            this.objectGrabPointTransform = null;
            objectRigidbody.useGravity = true;
    }

    private void FixedUpdate(){
        if(objectGrabPointTransform != null)
        {
            float lerpSpeed = 10f;
            Vector3 newPosition = Vector3.Lerp(transform.position, objectGrabPointTransform.position, Time.deltaTime * lerpSpeed);
            objectRigidbody.MovePosition(newPosition);
        }
    }
}
