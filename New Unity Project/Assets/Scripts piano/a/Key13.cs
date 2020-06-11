using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key13 : MonoBehaviour
{
public AudioSource key13;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key13.Play();

}    

private void OnMouseUp() {
  key13.Stop();
  rb.isKinematic=false;
}
}
