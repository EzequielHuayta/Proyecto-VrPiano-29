using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key52 : MonoBehaviour
{
public AudioSource key52;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key52.Play();

}    

private void OnMouseUp() {
  key52.Stop();
  rb.isKinematic=false;
}
}
