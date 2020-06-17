using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key88 : MonoBehaviour
{
public AudioSource key88;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key88.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key88.Stop();
  rb.isKinematic=false;
}
}
