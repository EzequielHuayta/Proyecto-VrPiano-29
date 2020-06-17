using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key46 : MonoBehaviour
{
public AudioSource key46;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key46.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key46.Stop();
  rb.isKinematic=false;
}
}
