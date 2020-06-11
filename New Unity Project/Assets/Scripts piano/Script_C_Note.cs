using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_C_Note : MonoBehaviour
{

public AudioSource C_Note;

//Cuando le hace click empieza
public KeyCode keyToPress;
 void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
             C_Note.Play();
        }
    }


}

