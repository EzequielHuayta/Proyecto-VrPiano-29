using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key3 : MonoBehaviour
{
public AudioSource key3;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key3.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key3.Stop();
  rb.isKinematic=false;
}
}

