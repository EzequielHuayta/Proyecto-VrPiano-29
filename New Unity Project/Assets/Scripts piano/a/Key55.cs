using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key55 : MonoBehaviour
{
public AudioSource key55;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key55.Play();

}    

private void OnMouseUp() {
  key55.Stop();
  rb.isKinematic=false;
}
}
