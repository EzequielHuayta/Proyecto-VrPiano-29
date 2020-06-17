using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key87 : MonoBehaviour
{
public AudioSource key87;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key87.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key87.Stop();
  rb.isKinematic=false;
}
}
