using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key80 : MonoBehaviour
{
public AudioSource key80;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key80.Play();

}    

private void OnMouseUp() {
  key80.Stop();
  rb.isKinematic=false;
}
}
