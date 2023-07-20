using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateInstant : MonoBehaviour
{
    public GameObject coffeeCup;

   void OnTriggerEnter (Collider cupTrigger)
    {
        if (cupTrigger.gameObject.tag == "Player")
        {
            Instantiate(coffeeCup, transform.position, transform.rotation);
        }
    }
}