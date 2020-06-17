using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key17 : MonoBehaviour
{
public AudioSource key17;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key17.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key17.Stop();
  rb.isKinematic=false;
}
}
