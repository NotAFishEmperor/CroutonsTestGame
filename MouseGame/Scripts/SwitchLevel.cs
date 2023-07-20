using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public string levelToLoad;

    public void LoadTheLevel () {
        Application.LoadLevel(levelToLoad);
    }
}