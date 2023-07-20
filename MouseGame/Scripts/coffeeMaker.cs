using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coffeeMaker : MonoBehaviour
{
    public ObjectType CupScript;

    void OnCollisionEnter (Collision coffeeTrigger)
    {
        if (coffeeTrigger.gameObject.tag == "Cup")
        {
            CupScript.coffee = true;
            Debug.Log("It's coffee!");
        }
    }
}
