using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key28 : MonoBehaviour
{
public AudioSource key28;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key28.Play();

}    

private void OnMouseUp() {
  key28.Stop();
  rb.isKinematic=false;
}
}
