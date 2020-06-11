using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key25 : MonoBehaviour
{
public AudioSource key25;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key25.Play();

}    

private void OnMouseUp() {
  key25.Stop();
  rb.isKinematic=false;
}
}
