using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key71 : MonoBehaviour
{
public AudioSource key71;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key71.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key71.Stop();
  rb.isKinematic=false;
}
}
