using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key79 : MonoBehaviour
{
public AudioSource key79;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key79.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key79.Stop();
  rb.isKinematic=false;
}
}
