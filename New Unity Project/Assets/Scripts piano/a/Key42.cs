using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key42 : MonoBehaviour
{
public AudioSource key42;
public Rigidbody rb;
public static int keyNumber = 42;

public static bool presionada = false;
private void OnMouseDown() 
{
presionada = true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key42.Play();

}    

private void OnMouseUp() {
  presionada = false;
  key42.Stop();
  rb.isKinematic=false;
}
}
