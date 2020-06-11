using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key3 : MonoBehaviour
{
public AudioSource key3;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key3.Play();

}    

private void OnMouseUp() {
  key3.Stop();
  rb.isKinematic=false;
}
}

