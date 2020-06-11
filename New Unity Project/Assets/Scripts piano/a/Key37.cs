using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key37 : MonoBehaviour
{
public AudioSource key37;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key37.Play();

}    

private void OnMouseUp() {
  key37.Stop();
  rb.isKinematic=false;
}
}
