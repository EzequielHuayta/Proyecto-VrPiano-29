using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key78 : MonoBehaviour
{
public AudioSource key78;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key78.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key78.Stop();
  rb.isKinematic=false;
}
}
