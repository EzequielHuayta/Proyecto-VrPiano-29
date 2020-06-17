using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key54 : MonoBehaviour
{
public AudioSource key54;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key54.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key54.Stop();
  rb.isKinematic=false;
}
}
