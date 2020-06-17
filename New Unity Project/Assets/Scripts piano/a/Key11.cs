using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key11 : MonoBehaviour
{
public AudioSource key11;
public Rigidbody rb;

public static bool presionada = false;

private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key11.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key11.Stop();
  rb.isKinematic=false;
}
}
