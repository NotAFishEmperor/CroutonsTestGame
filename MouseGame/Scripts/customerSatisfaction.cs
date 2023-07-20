using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerSatisfaction : MonoBehaviour
{
    public bool orderCoffee = false;
    public bool orderIcedCoffee = false;
    public bool orderCream = false;
    public bool orderSugar = false;
    public bool orderSmall = false;
    public bool orderMedium = false;
    public bool orderLarge = false;

    public int Order1;
    public int Order2;


    // Start is called before the first frame update
    void Start()
    {
        Order1 = Random.Range(1,6);
        Order2 = Random.Range(7,10);

        if(Order1 == 1)
        {
            orderLarge = true;
            orderCoffee = true;
        } 
        else if(Order1 == 2)
        {
            orderMedium = true;
            orderCoffee = true;
        }
        else if(Order1 == 3)
        {
            orderSmall = true;
            orderCoffee = true;
        }
        else if(Order1 == 4)
        {
            orderLarge = true;
            orderIcedCoffee = true;
        }
        else if(Order1 == 5)
        {
            orderMedium = true;
            orderIcedCoffee = true;
        }
        else if(Order1 == 6)
        {
            orderSmall = true;
            orderIcedCoffee = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
