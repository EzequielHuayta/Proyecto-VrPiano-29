using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key16 : MonoBehaviour
{
public AudioSource key16;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key16.Play();

}    

private void OnMouseUp() {
  key16.Stop();
  rb.isKinematic=false;
}
}
