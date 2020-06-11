using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key19 : MonoBehaviour
{
public AudioSource key19;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key19.Play();

}    

private void OnMouseUp() {
  key19.Stop();
  rb.isKinematic=false;
}
}
