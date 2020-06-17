using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key29 : MonoBehaviour
{
public AudioSource key29;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key29.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key29.Stop();
  rb.isKinematic=false;
}
}
