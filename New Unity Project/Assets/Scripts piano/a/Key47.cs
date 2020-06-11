using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key47 : MonoBehaviour
{
public AudioSource key47;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key47.Play();

}    

private void OnMouseUp() {
  key47.Stop();
  rb.isKinematic=false;
}
}
