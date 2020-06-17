using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key72 : MonoBehaviour
{
public AudioSource key72;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key72.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key72.Stop();
  rb.isKinematic=false;
}
}
