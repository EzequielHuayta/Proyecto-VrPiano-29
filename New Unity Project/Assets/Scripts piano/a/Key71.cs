using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key71 : MonoBehaviour
{
public AudioSource key71;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key71.Play();

}    

private void OnMouseUp() {
  key71.Stop();
  rb.isKinematic=false;
}
}
