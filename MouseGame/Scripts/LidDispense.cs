using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LidDispense : MonoBehaviour
{
    public ObjectType CupScript;

    void OnCollisionEnter (Collision coffeeTrigger)
    {
        if (coffeeTrigger.gameObject.tag == "Cup")
        {
            CupScript.lid = true;
            Debug.Log("It's got a lid!");
        }
    }
}
