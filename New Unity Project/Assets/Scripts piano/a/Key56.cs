using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key56 : MonoBehaviour
{
public AudioSource key56;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key56.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key56.Stop();
  rb.isKinematic=false;
}
}
