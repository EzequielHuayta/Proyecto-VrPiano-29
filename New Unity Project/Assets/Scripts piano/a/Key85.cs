﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key85 : MonoBehaviour
{
public AudioSource key85;
public Rigidbody rb;
public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key85.Play();

}    

private void OnMouseUp() {
  key85.Stop();
  rb.isKinematic=false;
}
}
