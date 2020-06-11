using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key56 : MonoBehaviour
{
public AudioSource key56;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key56.Play();

}    

private void OnMouseUp() {
  key56.Stop();
  rb.isKinematic=false;
}
}
