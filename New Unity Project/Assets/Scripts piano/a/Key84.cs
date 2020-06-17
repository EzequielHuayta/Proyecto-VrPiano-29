using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key84 : MonoBehaviour
{
public AudioSource key84;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key84.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key84.Stop();
  rb.isKinematic=false;
}
}
