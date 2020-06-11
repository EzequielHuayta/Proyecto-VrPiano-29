using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key69 : MonoBehaviour
{
public AudioSource key69;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key69.Play();

}    

private void OnMouseUp() {
  key69.Stop();
  rb.isKinematic=false;
}
}
