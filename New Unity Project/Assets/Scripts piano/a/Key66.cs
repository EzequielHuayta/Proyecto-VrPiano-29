﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key66 : MonoBehaviour
{
public AudioSource key66;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key66.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key66.Stop();
  rb.isKinematic=false;
}
}
