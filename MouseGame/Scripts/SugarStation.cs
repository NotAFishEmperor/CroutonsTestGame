using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SugarStation : MonoBehaviour
{
    public ObjectType CupScript;

    void OnCollisionEnter (Collision coffeeTrigger)
    {
        if (coffeeTrigger.gameObject.tag == "Cup")
        {
            CupScript.sugar = true;
            Debug.Log("It's sugar!");
        }
    }
}
