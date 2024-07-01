using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public Button botonJugar;

    void Update()
    {
        //botonJugar.interactable = false; // Deshabilitar el botón al inicio
        if (ColorManager.instancia.colorSeleccionado != Color.white) 
        {
            botonJugar.interactable = true; // Habilitar el botón si hay un color seleccionado
        }
        else
        {
            botonJugar.interactable = false; // Deshabilitar el botón si no hay un color seleccionado
        }
    }

    public void Jugar()
    {
        if (ColorManager.instancia.colorSeleccionado != Color.white) 
        {
            Debug.Log("Color seleccionado, cargando escena...");
            SceneManager.LoadScene(1); 
        }
        else
        {
            Debug.LogWarning("Selecciona un color antes de jugar."); // Mensaje de advertencia (opcional)
        }
    }
}
