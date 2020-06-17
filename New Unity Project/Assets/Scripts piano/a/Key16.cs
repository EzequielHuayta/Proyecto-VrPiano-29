using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key16 : MonoBehaviour
{
public AudioSource key16;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key16.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key16.Stop();
  rb.isKinematic=false;
}
}
