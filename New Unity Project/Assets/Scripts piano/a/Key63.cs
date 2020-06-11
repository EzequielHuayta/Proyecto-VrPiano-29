using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key63 : MonoBehaviour
{
public AudioSource key63;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key63.Play();

}    

private void OnMouseUp() {
  key63.Stop();
  rb.isKinematic=false;
}
}
