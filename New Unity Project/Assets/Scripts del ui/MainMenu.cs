using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

 public void JugarLibre()
    {
        SceneManager.LoadScene(2);
    }

public void JugarAprendizaje()
    {
        SceneManager.LoadScene(1);
    }
public void Salir()
    {
        Debug.Log("Salio");
        Application.Quit();
    }
}
