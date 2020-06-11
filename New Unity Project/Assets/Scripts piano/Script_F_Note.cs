using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_F_Note : MonoBehaviour
{
public AudioSource F_Note;
public KeyCode keyToPress;
 void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
             F_Note.Play();
        }
    }


}