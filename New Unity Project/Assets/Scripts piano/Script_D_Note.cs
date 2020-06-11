using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_D_Note : MonoBehaviour
{

public AudioSource D_Note;
public KeyCode keyToPress;
 void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
             D_Note.Play();
        }
    }


}


