using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key78 : MonoBehaviour
{
public AudioSource key78;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key78.Play();

}    

private void OnMouseUp() {
  key78.Stop();
  rb.isKinematic=false;
}
}
