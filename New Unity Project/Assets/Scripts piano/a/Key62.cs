using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key62 : MonoBehaviour
{
public AudioSource key62;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key62.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key62.Stop();
  rb.isKinematic=false;
}
}
