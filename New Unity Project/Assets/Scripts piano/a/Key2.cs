using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key2 : MonoBehaviour
{
public AudioSource key2;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key2.Play();

}    

private void OnMouseUp() {
  key2.Stop();
  rb.isKinematic=false;
}
}
