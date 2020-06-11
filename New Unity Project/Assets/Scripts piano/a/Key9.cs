using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key9 : MonoBehaviour
{
public AudioSource key9;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key9.Play();

}    

private void OnMouseUp() {
  key9.Stop();
  rb.isKinematic=false;
}
}
