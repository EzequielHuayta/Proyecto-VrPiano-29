﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key80 : MonoBehaviour
{
public AudioSource key80;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key80.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key80.Stop();
  rb.isKinematic=false;
}
}
