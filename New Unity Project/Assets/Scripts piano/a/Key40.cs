using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key40 : MonoBehaviour
{
public AudioSource key40;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key40.Play();

}    

private void OnMouseUp() {
  key40.Stop();
  rb.isKinematic=false;
}
}
