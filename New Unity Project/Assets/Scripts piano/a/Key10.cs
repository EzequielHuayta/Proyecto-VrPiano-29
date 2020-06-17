using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key10 : MonoBehaviour
{
public AudioSource key10;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key10.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key10.Stop();
  rb.isKinematic=false;
}
}
