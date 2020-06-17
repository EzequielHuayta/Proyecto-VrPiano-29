using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key77 : MonoBehaviour
{
public AudioSource key77;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key77.Play();

}    

private void OnMouseUp() {
presionada=false;
  key77.Stop();
  rb.isKinematic=false;
}
}
