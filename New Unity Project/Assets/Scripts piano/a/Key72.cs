using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key72 : MonoBehaviour
{
public AudioSource key72;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key72.Play();

}    

private void OnMouseUp() {
  key72.Stop();
  rb.isKinematic=false;
}
}
