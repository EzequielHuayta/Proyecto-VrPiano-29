using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key86 : MonoBehaviour
{
public AudioSource key86;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key86.Play();

}    

private void OnMouseUp() {
  key86.Stop();
  rb.isKinematic=false;
}
}
