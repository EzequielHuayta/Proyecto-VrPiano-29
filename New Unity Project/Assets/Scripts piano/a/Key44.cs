using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key44 : MonoBehaviour
{
public AudioSource key44;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key44.Play();

}    

private void OnMouseUp() {
  key44.Stop();
  rb.isKinematic=false;
}
}
