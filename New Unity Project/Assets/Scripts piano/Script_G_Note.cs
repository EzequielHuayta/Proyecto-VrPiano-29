using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_G_Note : MonoBehaviour
{
public AudioSource G_Note;
public KeyCode keyToPress;
 void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
             G_Note.Play();
        }
    }


}