using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key68 : MonoBehaviour
{
public AudioSource key68;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key68.Play();

}    

private void OnMouseUp() {
  key68.Stop();
  rb.isKinematic=false;
}
}
