using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key23 : MonoBehaviour
{
public AudioSource key23;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key23.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key23.Stop();
  rb.isKinematic=false;
}
}
