using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key49 : MonoBehaviour
{
public AudioSource key49;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key49.Play();

}    

private void OnMouseUp() {
  key49.Stop();
  rb.isKinematic=false;
}
}
