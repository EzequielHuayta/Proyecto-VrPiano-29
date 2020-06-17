using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key63 : MonoBehaviour
{
public AudioSource key63;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key63.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key63.Stop();
  rb.isKinematic=false;
}
}
