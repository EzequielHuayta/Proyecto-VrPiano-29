using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key74 : MonoBehaviour
{
public AudioSource key74;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key74.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key74.Stop();
  rb.isKinematic=false;
}
}
