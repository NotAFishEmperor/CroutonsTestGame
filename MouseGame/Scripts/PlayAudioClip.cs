using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioClip : MonoBehaviour
{
    public AudioClip myClip;
    AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        audioSource = GetComponent<AudioSource>();

        if(Input.GetKeyDown(KeyCode.A)){
            audioSource.PlayOneShot(myClip);
        }
    }
}
