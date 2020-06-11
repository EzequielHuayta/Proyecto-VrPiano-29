using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key33 : MonoBehaviour
{
public AudioSource key33;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key33.Play();

}    

private void OnMouseUp() {
  key33.Stop();
  rb.isKinematic=false;
}
}
