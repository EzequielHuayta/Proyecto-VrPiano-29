using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key35 : MonoBehaviour
{
public AudioSource key35;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key35.Play();

}    

private void OnMouseUp() {
  key35.Stop();
  rb.isKinematic=false;
}
}
