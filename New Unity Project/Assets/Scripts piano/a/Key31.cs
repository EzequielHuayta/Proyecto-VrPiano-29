using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key31 : MonoBehaviour
{
public AudioSource key31;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key31.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key31.Stop();
  rb.isKinematic=false;
}
}
