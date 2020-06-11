using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key17 : MonoBehaviour
{
public AudioSource key17;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key17.Play();

}    

private void OnMouseUp() {
  key17.Stop();
  rb.isKinematic=false;
}
}
