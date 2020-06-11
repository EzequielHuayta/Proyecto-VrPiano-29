using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key41 : MonoBehaviour
{
public AudioSource key41;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key41.Play();

}    

private void OnMouseUp() {
  key41.Stop();
  rb.isKinematic=false;
}
}
