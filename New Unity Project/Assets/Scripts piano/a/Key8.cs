using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key8 : MonoBehaviour
{
public AudioSource key8;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key8.Play();

}    

private void OnMouseUp() {
  key8.Stop();
  rb.isKinematic=false;
}
}
