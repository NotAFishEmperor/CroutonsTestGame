using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectType : MonoBehaviour
{
    public bool small = false;
    public bool medium = false;
    public bool large = false;
    public bool coffee = false;
    public bool icedCoffee = false;
    public bool cream = false;
    public bool sugar = false;
    public bool lid = false;
    
    public GameObject cup;


    // Start is called before the first frame update
    public void cupInstance () {
        Instantiate(cup, transform.position, transform.rotation);
    }

}
