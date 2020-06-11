using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key53 : MonoBehaviour
{
public AudioSource key53;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key53.Play();

}    

private void OnMouseUp() {
  key53.Stop();
  rb.isKinematic=false;
}
}
