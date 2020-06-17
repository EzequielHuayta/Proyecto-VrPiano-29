using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key30 : MonoBehaviour
{
public AudioSource key30;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key30.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key30.Stop();
  rb.isKinematic=false;
}
}
