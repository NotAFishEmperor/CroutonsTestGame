using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class registerCollider2 : MonoBehaviour
{
    public bool register2 = false;
    // Start is called before the first frame update
    void OnTriggerEnter (Collider cashCollider2)
    {
        if (cashCollider2.gameObject.tag == "NPC")
        {
            register2 = true;
        }
    }
        void OnTriggerExit (Collider cashCollider2)
    {
        if (cashCollider2.gameObject.tag == "NPC")
        {
            register2 = true;
        }
    }
}
