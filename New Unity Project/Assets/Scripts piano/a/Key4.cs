using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key4 : MonoBehaviour
{
public AudioSource key4;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key4.Play();

}    

private void OnMouseUp() {
  key4.Stop();
  rb.isKinematic=false;
}
}

