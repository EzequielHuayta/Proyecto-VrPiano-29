using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key64 : MonoBehaviour
{
public AudioSource key64;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key64.Play();

}    

private void OnMouseUp() {
  key64.Stop();
  rb.isKinematic=false;
}
}
