using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key35 : MonoBehaviour
{
public AudioSource key35;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key35.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key35.Stop();
  rb.isKinematic=false;
}
}
