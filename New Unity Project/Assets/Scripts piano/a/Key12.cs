﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key12 : MonoBehaviour
{
public AudioSource key12;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key12.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key12.Stop();
  rb.isKinematic=false;
}
}
