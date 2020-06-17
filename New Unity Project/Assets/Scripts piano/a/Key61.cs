using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key61 : MonoBehaviour
{
public AudioSource key61;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key61.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key61.Stop();
  rb.isKinematic=false;
}
}
