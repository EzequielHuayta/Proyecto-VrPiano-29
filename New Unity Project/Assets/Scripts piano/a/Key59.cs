using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key59 : MonoBehaviour
{
public AudioSource key59;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key59.Play();

}    

private void OnMouseUp() {
  key59.Stop();
  rb.isKinematic=false;
}
}
