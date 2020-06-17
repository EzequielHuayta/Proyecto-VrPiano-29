using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key86 : MonoBehaviour
{
public AudioSource key86;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key86.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key86.Stop();
  rb.isKinematic=false;
}
}
