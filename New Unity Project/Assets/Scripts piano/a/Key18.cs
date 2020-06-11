using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key18 : MonoBehaviour
{
public AudioSource key18;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key18.Play();

}    

private void OnMouseUp() {
  key18.Stop();
  rb.isKinematic=false;
}
}
