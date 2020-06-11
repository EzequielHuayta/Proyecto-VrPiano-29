using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key26 : MonoBehaviour
{
public AudioSource key26;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key26.Play();

}    

private void OnMouseUp() {
  key26.Stop();
  rb.isKinematic=false;
}
}
