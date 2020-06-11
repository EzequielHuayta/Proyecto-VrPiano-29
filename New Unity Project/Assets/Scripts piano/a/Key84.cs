using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key84 : MonoBehaviour
{
public AudioSource key84;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key84.Play();

}    

private void OnMouseUp() {
  key84.Stop();
  rb.isKinematic=false;
}
}
