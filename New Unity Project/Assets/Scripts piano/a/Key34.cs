using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key34 : MonoBehaviour
{
public AudioSource key34;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key34.Play();

}    

private void OnMouseUp() {
  key34.Stop();
  rb.isKinematic=false;
}
}
