using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key58 : MonoBehaviour
{
public AudioSource key58;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key58.Play();

}    

private void OnMouseUp() {
  key58.Stop();
  rb.isKinematic=false;
}
}
