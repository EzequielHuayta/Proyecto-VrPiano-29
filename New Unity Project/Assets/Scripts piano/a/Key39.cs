using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key39 : MonoBehaviour
{
public AudioSource key39;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key39.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key39.Stop();
  rb.isKinematic=false;
}
}
