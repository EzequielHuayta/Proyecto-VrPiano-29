using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1 : MonoBehaviour
{
public AudioSource key1;

public Rigidbody rb;

public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key1.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key1.Stop();
  rb.isKinematic=false;
}
}
