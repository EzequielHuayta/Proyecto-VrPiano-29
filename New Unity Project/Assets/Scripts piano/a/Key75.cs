using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key75 : MonoBehaviour
{
public AudioSource key75;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key75.Play();

}    

private void OnMouseUp() {
  key75.Stop();
  rb.isKinematic=false;
}
}
