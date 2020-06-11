using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key21 : MonoBehaviour
{
public AudioSource key21;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key21.Play();

}    

private void OnMouseUp() {
  key21.Stop();
  rb.isKinematic=false;
}
}
