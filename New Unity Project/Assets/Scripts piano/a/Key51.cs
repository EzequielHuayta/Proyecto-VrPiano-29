using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key51 : MonoBehaviour
{
public AudioSource key51;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key51.Play();

}    

private void OnMouseUp() {
  key51.Stop();
  rb.isKinematic=false;
}
}
