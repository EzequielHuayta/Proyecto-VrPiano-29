using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key13 : MonoBehaviour
{
public AudioSource key13;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key13.Play();

}    

private void OnMouseUp() {
  presionada=true;
  key13.Stop();
  rb.isKinematic=false;
}
}
