using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class AudioManager : MonoBehaviour
{
public AudioSource BGM;

void Start()
{

}

void Update()
{

}

public void ChangeBGM(AudioClip music)
{
BGM.Stop();
BGM.clip = music;
BGM.Play();

}
}
