using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key83 : MonoBehaviour
{
public AudioSource key83;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key83.Play();

}    

private void OnMouseUp() {
  key83.Stop();
  rb.isKinematic=false;
}
}
