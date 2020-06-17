using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key76 : MonoBehaviour
{
public AudioSource key76;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key76.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key76.Stop();
  rb.isKinematic=false;
}
}
