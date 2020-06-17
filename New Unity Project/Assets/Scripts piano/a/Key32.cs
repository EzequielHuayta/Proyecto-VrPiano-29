using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key32 : MonoBehaviour
{
public AudioSource key32;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key32.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key32.Stop();
  rb.isKinematic=false;
}
}
