using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key7 : MonoBehaviour
{
public AudioSource key7;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada = true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key7.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key7.Stop();
  rb.isKinematic=false;
}
}
