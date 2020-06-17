using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key47 : MonoBehaviour
{
public AudioSource key47;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key47.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key47.Stop();
  rb.isKinematic=false;
}
}
