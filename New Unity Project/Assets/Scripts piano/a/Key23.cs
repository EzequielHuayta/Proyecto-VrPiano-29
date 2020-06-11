using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key23 : MonoBehaviour
{
public AudioSource key23;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key23.Play();

}    

private void OnMouseUp() {
  key23.Stop();
  rb.isKinematic=false;
}
}
