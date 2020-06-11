using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key7 : MonoBehaviour
{
public AudioSource key7;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key7.Play();

}    

private void OnMouseUp() {
  key7.Stop();
  rb.isKinematic=false;
}
}
