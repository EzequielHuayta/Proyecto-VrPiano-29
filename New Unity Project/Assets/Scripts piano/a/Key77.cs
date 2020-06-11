using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key77 : MonoBehaviour
{
public AudioSource key77;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key77.Play();

}    

private void OnMouseUp() {
  key77.Stop();
  rb.isKinematic=false;
}
}
