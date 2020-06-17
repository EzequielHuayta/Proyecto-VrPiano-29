using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key4 : MonoBehaviour
{
public AudioSource key4;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key4.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key4.Stop();
  rb.isKinematic=false;
}
}

