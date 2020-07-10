using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject42 : MonoBehaviour
{
    public bool canBePressed;
    public string numeroflecha;

   public GameObject g;
    public GameObject tecla;

public bool c;
      private static bool TeclaNumero;

  private bool ok;
    // Start is called before the first frame update


    void Start()
    {
g = GameObject.Find(numeroflecha);
PrefabKey b = g.GetComponent<PrefabKey>();
c = b.presionada;

    }

    // Update is called once per frame
    void Update()
    {
//TeclaNumero = PrefabKey.presionada;
Debug.Log(TeclaNumero);
        if(Input.GetMouseButton(0) && c == true)
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

        if(numeroflecha == other.gameObject.name)
        {
            Debug.Log(other.gameObject.name);
            canBePressed = true;
        }
        

    }
    private void OnTriggerExit(Collider other)
    {

        if(numeroflecha == other.gameObject.name)
        {
                    Debug.Log(other.gameObject.name);
        
            canBePressed = false;
            GameManager.instance.NoteMissed();
             gameObject.SetActive(false);
        
        }
    }

}

