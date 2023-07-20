using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreamMachine : MonoBehaviour
{
    public ObjectType CupScript;

    void OnCollisionEnter (Collision coffeeTrigger)
    {
        if (coffeeTrigger.gameObject.tag == "Cup")
        {
            CupScript.cream = true;
            Debug.Log("It's cream!");
        }
    }
}
