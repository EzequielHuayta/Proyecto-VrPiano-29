using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key67 : MonoBehaviour
{
public AudioSource key67;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key67.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key67.Stop();
  rb.isKinematic=false;
}
}
