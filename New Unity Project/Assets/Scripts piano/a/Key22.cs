using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key22 : MonoBehaviour
{
public AudioSource key22;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key22.Play();

}    

private void OnMouseUp() {
  key22.Stop();
  rb.isKinematic=false;
}
}
