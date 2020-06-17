using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key49 : MonoBehaviour
{
public AudioSource key49;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key49.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key49.Stop();
  rb.isKinematic=false;
}
}
