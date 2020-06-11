using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key60 : MonoBehaviour
{
public AudioSource key60;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key60.Play();

}    

private void OnMouseUp() {
  key60.Stop();
  rb.isKinematic=false;
}
}
