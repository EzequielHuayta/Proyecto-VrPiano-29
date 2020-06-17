using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject37 : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    public int Flecha;

    public GameObject tecla;

      private static bool TeclaNumero;
  private bool ok;
    // Start is called before the first frame update
    void Start()
    {
 
    }





    // Update is called once per frame
    void Update()
    {
TeclaNumero = Key37.presionada;
        if(Input.GetMouseButton(0) && TeclaNumero == true)
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
        if(other.tag == "Activator37" )
        {
            canBePressed = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Activator37" )
        {
        {
            canBePressed = false;

            GameManager.instance.NoteMissed();
        }
        }
    }

}
