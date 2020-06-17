using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key83 : MonoBehaviour
{
public AudioSource key83;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key83.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key83.Stop();
  rb.isKinematic=false;
}
}
