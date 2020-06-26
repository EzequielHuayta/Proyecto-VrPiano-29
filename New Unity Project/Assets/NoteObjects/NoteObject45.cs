using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject45 : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    public int Flecha;
    
    private int a = 0;
    public GameObject tecla;

      private static bool TeclaNumero;
      private static bool asd;

  private bool ok;
    // Start is called before the first frame update
    void Start()
    {
 
    }





    // Update is called once per frame
    void Update()
    {
TeclaNumero = Key45.presionada;

        if(Input.GetMouseButton(0) && TeclaNumero == true && GameManager.prueba == false)
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
        if(GameManager.prueba == false)
        
        {
        if(other.tag == "Activator45" )
        {
            canBePressed = true;
           
        }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Activator45" )
        {
        {
            canBePressed = false;

            GameManager.instance.NoteMissed();
            gameObject.SetActive(false);
        }
        }
    }
}
