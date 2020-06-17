using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key19 : MonoBehaviour
{
public AudioSource key19;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key19.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key19.Stop();
  rb.isKinematic=false;
}
}
