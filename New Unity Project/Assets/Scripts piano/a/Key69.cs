using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key69 : MonoBehaviour
{
public AudioSource key69;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key69.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key69.Stop();
  rb.isKinematic=false;
}
}
