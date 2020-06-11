using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key54 : MonoBehaviour
{
public AudioSource key54;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key54.Play();

}    

private void OnMouseUp() {
  key54.Stop();
  rb.isKinematic=false;
}
}
