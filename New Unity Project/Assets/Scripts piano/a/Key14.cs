using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key14 : MonoBehaviour
{
public AudioSource key14;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key14.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key14.Stop();
  rb.isKinematic=false;
}
}
