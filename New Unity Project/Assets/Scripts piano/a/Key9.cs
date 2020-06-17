using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key9 : MonoBehaviour
{
public AudioSource key9;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key9.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key9.Stop();
  rb.isKinematic=false;
}
}
