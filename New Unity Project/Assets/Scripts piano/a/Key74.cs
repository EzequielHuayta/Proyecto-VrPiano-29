using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key74 : MonoBehaviour
{
public AudioSource key74;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key74.Play();

}    

private void OnMouseUp() {
  key74.Stop();
  rb.isKinematic=false;
}
}
