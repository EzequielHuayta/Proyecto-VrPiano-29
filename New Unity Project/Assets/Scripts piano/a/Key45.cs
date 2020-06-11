using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key45 : MonoBehaviour
{
public AudioSource key45;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key45.Play();

}    

private void OnMouseUp() {
  key45.Stop();
  rb.isKinematic=false;
}
}
