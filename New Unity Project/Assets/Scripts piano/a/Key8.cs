using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key8 : MonoBehaviour
{
public AudioSource key8;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key8.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key8.Stop();
  rb.isKinematic=false;
}
}
