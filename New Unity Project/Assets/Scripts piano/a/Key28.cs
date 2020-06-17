using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key28 : MonoBehaviour
{
public AudioSource key28;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
  presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key28.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key28.Stop();
  rb.isKinematic=false;
}
}
