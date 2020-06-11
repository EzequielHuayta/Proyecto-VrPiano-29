using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_E_Note : MonoBehaviour
{
public AudioSource E_Note;
public KeyCode keyToPress;
 void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
             E_Note.Play();
        }
    }

}
