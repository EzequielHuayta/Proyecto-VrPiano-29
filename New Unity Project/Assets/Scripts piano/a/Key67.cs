using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key67 : MonoBehaviour
{
public AudioSource key67;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key67.Play();

}    

private void OnMouseUp() {
  key67.Stop();
  rb.isKinematic=false;
}
}
