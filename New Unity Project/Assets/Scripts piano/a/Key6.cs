using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key6 : MonoBehaviour
{
public AudioSource key6;

public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key6.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key6.Stop();
  rb.isKinematic=false;
}

}
