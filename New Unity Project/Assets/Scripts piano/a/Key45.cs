using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key45 : MonoBehaviour
{
public AudioSource key45;
public Rigidbody rb;

public static int keyNumber = 45;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada = true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key45.Play();

}    

private void OnMouseUp() {
  presionada = false;
  key45.Stop();
  rb.isKinematic=false;
}
}
