using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key64 : MonoBehaviour
{
public AudioSource key64;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key64.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key64.Stop();
  rb.isKinematic=false;
}
}
