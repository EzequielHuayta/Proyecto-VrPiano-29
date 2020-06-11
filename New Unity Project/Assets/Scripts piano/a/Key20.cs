using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key20 : MonoBehaviour
{
public AudioSource key20;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key20.Play();

}    

private void OnMouseUp() {
  key20.Stop();
  rb.isKinematic=false;
}
}
