using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key24 : MonoBehaviour
{
public AudioSource key24;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key24.Play();

}    

private void OnMouseUp() {
  key24.Stop();
  rb.isKinematic=false;
}
}
