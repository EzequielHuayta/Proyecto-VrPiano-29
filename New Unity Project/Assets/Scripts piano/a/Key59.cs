using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key59 : MonoBehaviour
{
public AudioSource key59;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key59.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key59.Stop();
  rb.isKinematic=false;
}
}
