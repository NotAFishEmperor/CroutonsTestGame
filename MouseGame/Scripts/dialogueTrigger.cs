using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class dialogueTrigger : MonoBehaviour
{
    public Dialogue DialogueScript;

    void OnTriggerEnter (Collider dialogueTrigger)
    {
        if (dialogueTrigger.gameObject.tag == "Player")
        {
            DialogueScript.DialogueTrigger();

        }
    }

    void OnTriggerExit (Collider dialogueTrigger)
    {
        if (dialogueTrigger.gameObject.tag == "Player")
        {
            DialogueScript.DialogueExit();

        }
    }
}
