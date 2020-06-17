using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key48 : MonoBehaviour
{
public AudioSource key48;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key48.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key48.Stop();
  rb.isKinematic=false;
}
}
