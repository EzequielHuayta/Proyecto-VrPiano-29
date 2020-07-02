using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScriptNombre : MonoBehaviour
{
    private static string Nombre;
    public TextMeshProUGUI TextoDelNombre;
    public TextMeshProUGUI Dificultad;
    // Start is called before the first frame update
    void Start()
    {
        Nombre = Cancion.NombreCancion;
        TextoDelNombre.text = "Cancion: " + Nombre;

        if(Nombre == "Under the sea")
        {
            Dificultad.text="Dificultad: Medio";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
