using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key27 : MonoBehaviour
{
public AudioSource key27;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key27.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key27.Stop();
  rb.isKinematic=false;
}
}
