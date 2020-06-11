using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key87 : MonoBehaviour
{
public AudioSource key87;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key87.Play();

}    

private void OnMouseUp() {
  key87.Stop();
  rb.isKinematic=false;
}
}
