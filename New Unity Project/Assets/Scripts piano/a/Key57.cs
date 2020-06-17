using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key57 : MonoBehaviour
{
public AudioSource key57;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key57.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key57.Stop();
  rb.isKinematic=false;
}
}
