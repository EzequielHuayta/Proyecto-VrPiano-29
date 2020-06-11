using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key76 : MonoBehaviour
{
public AudioSource key76;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key76.Play();

}    

private void OnMouseUp() {
  key76.Stop();
  rb.isKinematic=false;
}
}
