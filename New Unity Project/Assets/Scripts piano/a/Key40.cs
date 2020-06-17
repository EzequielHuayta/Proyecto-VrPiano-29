using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key40 : MonoBehaviour
{
public AudioSource key40;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key40.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key40.Stop();
  rb.isKinematic=false;
}
}
