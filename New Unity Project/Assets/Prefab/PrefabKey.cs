using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabKey : MonoBehaviour
{
public AudioSource key;

public string nombre;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key.Stop();
  rb.isKinematic=false;
}

}