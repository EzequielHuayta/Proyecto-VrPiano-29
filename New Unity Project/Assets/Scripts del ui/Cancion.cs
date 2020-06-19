using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class Cancion : MonoBehaviour
{
    public static string NombreCancion;
    public Text changingtext;

    public GameObject aObject;
    public Button aButton;
public AudioClip newTrack;

private AudioManager theAM;

void Start (){

    NombreCancion = gameObject.name;
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




