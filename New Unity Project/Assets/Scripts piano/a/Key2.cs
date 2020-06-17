using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key2 : MonoBehaviour
{
public AudioSource key2;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key2.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key2.Stop();
  rb.isKinematic=false;
}
}
