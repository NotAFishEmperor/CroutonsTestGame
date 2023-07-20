using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class registerCollider1 : MonoBehaviour
{
    public bool register1 = false;
    // Start is called before the first frame update
    void OnTriggerEnter (Collider cashCollider1)
    {
        if (cashCollider1.gameObject.tag == "NPC")
        {
            register1 = true;
        }
    }
        void OnTriggerExit (Collider cashCollider1)
    {
        if (cashCollider1.gameObject.tag == "NPC")
        {
            register1 = true;
        }
    }
}
