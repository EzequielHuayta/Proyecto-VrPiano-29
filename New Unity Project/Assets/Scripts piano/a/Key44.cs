using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key44 : MonoBehaviour
{
public AudioSource key44;
public Rigidbody rb;

public static bool presionada = false;
private void OnMouseDown() 
{
presionada = true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key44.Play();

}    

private void OnMouseUp() {
  presionada = false;
  key44.Stop();
  rb.isKinematic=false;
}
}
