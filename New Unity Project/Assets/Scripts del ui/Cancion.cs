using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class Cancion : MonoBehaviour
{
    public Text changingtext;

    public GameObject aObject;
    public Button aButton;
public AudioClip newTrack;

private AudioManager theAM;

void Start (){


    theAM = FindObjectOfType<AudioManager>();

}

void Update(){

}

public void Toco(bool a){
    string objectName = gameObject.name;

    if (a == true)
    {
        if(newTrack!=null)
theAM.ChangeBGM(newTrack);
    }
}
}




