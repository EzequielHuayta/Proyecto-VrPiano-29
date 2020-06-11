using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key14 : MonoBehaviour
{
public AudioSource key14;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key14.Play();

}    

private void OnMouseUp() {
  key14.Stop();
  rb.isKinematic=false;
}
}
