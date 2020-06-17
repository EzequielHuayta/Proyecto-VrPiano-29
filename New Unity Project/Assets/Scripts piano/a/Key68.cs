using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key68 : MonoBehaviour
{
public AudioSource key68;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key68.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key68.Stop();
  rb.isKinematic=false;
}
}
