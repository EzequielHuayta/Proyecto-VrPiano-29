using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1 : MonoBehaviour
{
public AudioSource key1;

public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key1.Play();

}    

private void OnMouseUp() {
  key1.Stop();
  rb.isKinematic=false;
}
}
