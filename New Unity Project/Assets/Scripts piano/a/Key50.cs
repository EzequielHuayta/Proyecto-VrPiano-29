using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key50 : MonoBehaviour
{
public AudioSource key50;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key50.Play();

}    

private void OnMouseUp() {
  key50.Stop();
  rb.isKinematic=false;
}
}
