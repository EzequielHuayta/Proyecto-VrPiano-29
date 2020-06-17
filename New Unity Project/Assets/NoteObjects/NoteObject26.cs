using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject26 : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
        public bool Sostenido;
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
TeclaNumero = Key26.presionada;
        if(Input.GetMouseButton(0) && TeclaNumero == true)
        {
         if(canBePressed)
            {
            gameObject.SetActive(false);

            GameManager.instance.NoteHit();
            }

        }
        if(Sostenido)
        {
           GameManager.instance.NoteSustained(); 
        }
    }
   private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Activator26" )
        {
            canBePressed = true;
        }
    }
        private void OnTriggerStay(Collider other)
    {
        Debug.Log("esta");
        if(other.tag == "Activator88" )
        {
            Sostenido = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Activator26" )
        {
        {
            canBePressed = false;

            GameManager.instance.NoteMissed();
            gameObject.SetActive(false);
        }
        }
    }
}