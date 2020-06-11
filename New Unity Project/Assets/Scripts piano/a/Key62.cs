using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key62 : MonoBehaviour
{
public AudioSource key62;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key62.Play();

}    

private void OnMouseUp() {
  key62.Stop();
  rb.isKinematic=false;
}
}
