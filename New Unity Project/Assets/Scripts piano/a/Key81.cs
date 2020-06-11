using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key81 : MonoBehaviour
{
public AudioSource key81;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key81.Play();

}    

private void OnMouseUp() {
  key81.Stop();
  rb.isKinematic=false;
}
}
