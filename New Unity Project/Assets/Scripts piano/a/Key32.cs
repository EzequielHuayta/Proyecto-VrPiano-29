using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key32 : MonoBehaviour
{
public AudioSource key32;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key32.Play();

}    

private void OnMouseUp() {
  key32.Stop();
  rb.isKinematic=false;
}
}
