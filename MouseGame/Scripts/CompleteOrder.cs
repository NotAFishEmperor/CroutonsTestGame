using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteOrder : MonoBehaviour
{
    public ObjectType CupScript;
    public customerSatisfaction CustomerScript;
    public int Counter = 0;

    void OnCollisionEnter (Collision orderTrigger)
    {
        if (orderTrigger.gameObject.tag == "Cup")
        {
            if ((CustomerScript.orderCoffee == CupScript.coffee)&&(CustomerScript.orderIcedCoffee == CupScript.icedCoffee)&&(CustomerScript.orderCream == CupScript.cream)&&(CustomerScript.orderSugar == CupScript.sugar)&&(CupScript.sugar))
            {
                Debug.Log("Thanks!");
            } 
            else if ((CustomerScript.orderCoffee == CupScript.coffee)||(CustomerScript.orderIcedCoffee == CupScript.icedCoffee)||(CustomerScript.orderCream == CupScript.cream)||(CustomerScript.orderSugar == CupScript.sugar)||(CupScript.lid))
            {
                Debug.Log("This isn't quite right...");
            }
            else
            {
                Debug.Log("This is the wrong order...");
            }
        }
    }
}
