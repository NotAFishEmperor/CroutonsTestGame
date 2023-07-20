using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickupDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private Transform objectGrabPointTransform;
    [SerializeField] private LayerMask pickupLayerMask;

    private objectGrabable objectGrabable;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Change from GetButton to GetButtonDown
        {
            if (objectGrabable == null)
            {
                float pickUpDistance = 2f;
                if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpDistance))
                {
                    if (raycastHit.transform.TryGetComponent(out objectGrabable))
                    {
                        objectGrabable.Grab(objectGrabPointTransform);
                        Debug.Log("grabbed");
                    }
                }
            }
            else
            {
                objectGrabable.Drop();
                objectGrabable = null;
            }
        }
    }
}