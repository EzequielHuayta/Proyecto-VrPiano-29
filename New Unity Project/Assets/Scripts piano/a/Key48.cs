using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key48 : MonoBehaviour
{
public AudioSource key48;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key48.Play();

}    

private void OnMouseUp() {
  key48.Stop();
  rb.isKinematic=false;
}
}
