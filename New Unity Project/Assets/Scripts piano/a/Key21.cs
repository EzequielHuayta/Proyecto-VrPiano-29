using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key21 : MonoBehaviour
{
public AudioSource key21;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key21.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key21.Stop();
  rb.isKinematic=false;
}
}
