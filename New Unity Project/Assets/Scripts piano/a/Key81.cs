using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key81 : MonoBehaviour
{
public AudioSource key81;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key81.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key81.Stop();
  rb.isKinematic=false;
}
}
