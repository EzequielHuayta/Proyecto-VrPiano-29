using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key65 : MonoBehaviour
{
public AudioSource key65;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key65.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key65.Stop();
  rb.isKinematic=false;
}
}
