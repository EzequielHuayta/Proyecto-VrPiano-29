using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key75 : MonoBehaviour
{
public AudioSource key75;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key75.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key75.Stop();
  rb.isKinematic=false;
}
}
