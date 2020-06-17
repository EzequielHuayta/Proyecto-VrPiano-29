using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key51 : MonoBehaviour
{
public AudioSource key51;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key51.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key51.Stop();
  rb.isKinematic=false;
}
}
