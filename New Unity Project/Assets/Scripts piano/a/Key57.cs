using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key57 : MonoBehaviour
{
public AudioSource key57;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key57.Play();

}    

private void OnMouseUp() {
  key57.Stop();
  rb.isKinematic=false;
}
}
