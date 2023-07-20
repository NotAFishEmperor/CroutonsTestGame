using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icedCoffeeMaker : MonoBehaviour
{
    public ObjectType CupScript;

    void OnCollisionEnter (Collision coffeeTrigger)
    {
        if (coffeeTrigger.gameObject.tag == "Cup")
        {
            CupScript.icedCoffee = true;
            Debug.Log("It's iced coffee!");
        }
    }
}
