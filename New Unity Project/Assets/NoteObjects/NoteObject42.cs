﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject42 : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPress;
    
    public string nombrecomparar;

    public string numeroflecha;

    public GameObject tecla;

      private static bool TeclaNumero;

  private bool ok;
    // Start is called before the first frame update


    void Start()
    {
PrefabKey variable = GetComponent<PrefabKey>();
nombrecomparar = variable.nombre;
Debug.Log(nombrecomparar);
    }

    // Update is called once per frame
    void Update()
    {
TeclaNumero = Key42.presionada;

        if(Input.GetMouseButton(0) && TeclaNumero == true)
        {
         if(canBePressed )
            {
            gameObject.SetActive(false);
            TeclaNumero=false;
            GameManager.instance.NoteHit();
            
            }

        }

    }



   private void OnTriggerEnter(Collider other)
    {

        if(nombrecomparar == numeroflecha)
        {
            canBePressed = true;
        }
        

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Activator42" )
        {
        {
            canBePressed = false;
            GameManager.instance.NoteMissed();
             gameObject.SetActive(false);
        }
        }
    }

}

