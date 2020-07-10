using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject45 : MonoBehaviour
{
    public bool canBePressed;


    public GameObject tecla;

   public GameObject g;
    public string numeroflecha;
   private static bool TeclaNumero;

public bool c;
  private bool ok;
    // Start is called before the first frame update
    void Start()
    {

    }





    // Update is called once per frame
    void Update()
    {
//TeclaNumero = PrefabKey.presionada;
PrefabKey b = g.GetComponent<PrefabKey>();
c = b.presionada;
Debug.Log(c);
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
            canBePressed = true;
           
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if(numeroflecha == other.gameObject.name)
        {
        
            canBePressed = false;

            GameManager.instance.NoteMissed();
            gameObject.SetActive(false);
        
        }
    }
}
