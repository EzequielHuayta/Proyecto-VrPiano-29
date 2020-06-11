using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key38 : MonoBehaviour
{
public AudioSource key38;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key38.Play();

}    

private void OnMouseUp() {
  key38.Stop();
  rb.isKinematic=false;
}
}
