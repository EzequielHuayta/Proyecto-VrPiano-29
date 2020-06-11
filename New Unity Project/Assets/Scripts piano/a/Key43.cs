using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key43 : MonoBehaviour
{
public AudioSource key43;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key43.Play();

}    

private void OnMouseUp() {
  key43.Stop();
  rb.isKinematic=false;
}
}
