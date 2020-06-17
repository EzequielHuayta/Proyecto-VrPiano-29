using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key38 : MonoBehaviour
{
public AudioSource key38;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key38.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key38.Stop();
  rb.isKinematic=false;
}
}
