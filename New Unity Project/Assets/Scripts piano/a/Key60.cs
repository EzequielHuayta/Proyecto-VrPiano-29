using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key60 : MonoBehaviour
{
public AudioSource key60;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key60.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key60.Stop();
  rb.isKinematic=false;
}
}
