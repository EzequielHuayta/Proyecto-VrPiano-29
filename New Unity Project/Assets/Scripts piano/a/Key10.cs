using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key10 : MonoBehaviour
{
public AudioSource key10;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key10.Play();

}    

private void OnMouseUp() {
  key10.Stop();
  rb.isKinematic=false;
}
}
