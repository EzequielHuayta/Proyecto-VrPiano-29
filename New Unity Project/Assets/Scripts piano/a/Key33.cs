﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key33 : MonoBehaviour
{
public AudioSource key33;
public Rigidbody rb;

public static bool presionada = false;
private void OnMouseDown() 
{
presionada=true;
  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key33.Play();

}    

private void OnMouseUp() {
  presionada=false;
  key33.Stop();
  rb.isKinematic=false;
}
}
