using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key15 : MonoBehaviour
{
public AudioSource key15;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key15.Play();

}    

private void OnMouseUp() {
  key15.Stop();
  rb.isKinematic=false;
}
}
