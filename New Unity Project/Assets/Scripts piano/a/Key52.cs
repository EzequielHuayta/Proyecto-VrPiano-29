using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key52 : MonoBehaviour
{
public AudioSource key52;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key52.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key52.Stop();
  rb.isKinematic=false;
}
}
