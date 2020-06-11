using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key82 : MonoBehaviour
{
public AudioSource key82;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key82.Play();

}    

private void OnMouseUp() {
  key82.Stop();
  rb.isKinematic=false;
}
}
