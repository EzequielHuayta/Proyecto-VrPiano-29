using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key65 : MonoBehaviour
{
public AudioSource key65;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key65.Play();

}    

private void OnMouseUp() {
  key65.Stop();
  rb.isKinematic=false;
}
}
