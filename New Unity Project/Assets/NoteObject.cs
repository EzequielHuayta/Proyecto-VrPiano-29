using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    public string Flecha;

    public GameObject tecla;
  
  private bool ok;
    // Start is called before the first frame update
    void Start()
    {

    }





    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
         if(canBePressed)
            {
            gameObject.SetActive(false);

            GameManager.instance.NoteHit();
            }
        }
    }
   private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Activator" )
        {
            canBePressed = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Activator" )
        {
        {
            canBePressed = false;

            GameManager.instance.NoteMissed();
        }
        }
    }
}

