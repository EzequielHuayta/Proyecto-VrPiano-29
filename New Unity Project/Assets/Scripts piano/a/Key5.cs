using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key5 : MonoBehaviour
{
public AudioSource key5;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key5.Play();

}    

private void OnMouseUp() {
  key5.Stop();
  rb.isKinematic=false;
}
}

