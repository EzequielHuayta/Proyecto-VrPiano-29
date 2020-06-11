using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key46 : MonoBehaviour
{
public AudioSource key46;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key46.Play();

}    

private void OnMouseUp() {
  key46.Stop();
  rb.isKinematic=false;
}
}
