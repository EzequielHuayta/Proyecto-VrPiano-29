using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key73 : MonoBehaviour
{
public AudioSource key73;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key73.Play();

}    

private void OnMouseUp() {
  key73.Stop();
  rb.isKinematic=false;
}
}
