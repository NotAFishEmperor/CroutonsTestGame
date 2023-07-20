using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public customerSatisfaction CustomerScript;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public int index;
    private bool MouseTrigger = true;    

    public void DialogueExit()
    {
        MouseTrigger = false;
        gameObject.SetActive(false);

    }
    public void DialogueTrigger()
    {
        StartDialogue();
    }

    void StartDialogue()
    {
        index = 0;
        textComponent.text = string.Empty;
        gameObject.SetActive(true);
        MouseTrigger = true;
        StartCoroutine(TypeLine());
    }

    void Update()
    {
        if(MouseTrigger == true){

            if (Input.GetMouseButtonDown(0)) // Changed from GetMouseDown to GetMouseButtonDown
            {
                if (textComponent.text == lines[index])
                {
                    NextLine();
                }
                else
                {
                    StopAllCoroutines();
                    textComponent.text = lines[index];
                }
            }
        }
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c; 
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index == 0)
        // index < lines.Length - 1
        {

            index =  CustomerScript.Order1;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());


        }
        else if (index > 0 && index < 6)
        // index < lines.Length - 1
        {    
            index =  CustomerScript.Order2;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());

        }
        else if (index > 6)
        {
            gameObject.SetActive(false);
        } 
    }
}