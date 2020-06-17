using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key55 : MonoBehaviour
{
public AudioSource key55;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key55.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key55.Stop();
  rb.isKinematic=false;
}
}
