using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key61 : MonoBehaviour
{
public AudioSource key61;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key61.Play();

}    

private void OnMouseUp() {
  key61.Stop();
  rb.isKinematic=false;
}
}
