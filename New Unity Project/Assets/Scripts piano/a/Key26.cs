using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key26 : MonoBehaviour
{
public AudioSource key26;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key26.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key26.Stop();
  rb.isKinematic=false;
}
}
