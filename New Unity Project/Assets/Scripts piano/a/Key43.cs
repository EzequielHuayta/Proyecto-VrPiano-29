using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key43 : MonoBehaviour
{
public AudioSource key43;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada = true;

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key43.Play();

}    

private void OnMouseUp() {
    presionada = false;
  key43.Stop();
  rb.isKinematic=false;
}
}
