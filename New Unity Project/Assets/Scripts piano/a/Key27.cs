using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key27 : MonoBehaviour
{
public AudioSource key27;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key27.Play();

}    

private void OnMouseUp() {
  key27.Stop();
  rb.isKinematic=false;
}
}
