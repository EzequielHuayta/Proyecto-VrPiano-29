using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key50 : MonoBehaviour
{
public AudioSource key50;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key50.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key50.Stop();
  rb.isKinematic=false;
}
}
