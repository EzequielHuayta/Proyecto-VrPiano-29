using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key79 : MonoBehaviour
{
public AudioSource key79;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key79.Play();

}    

private void OnMouseUp() {
  key79.Stop();
  rb.isKinematic=false;
}
}
