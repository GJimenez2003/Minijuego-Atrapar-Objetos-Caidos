using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static ColorManager instancia; // Singleton para acceder al color desde cualquier script

    public Color colorSeleccionado;

    void Awake()
    {
        // Singleton
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject); // Persistir entre escenas
        }
        else
        {
            Destroy(gameObject);
        }

        colorSeleccionado = Color.white; // Color inicial por defecto
    }

    public void SeleccionarColorRojo()
    {
        colorSeleccionado = Color.red;
        Debug.Log("Color seleccionado: Rojo");
    }

    public void SeleccionarColorVerde()
    {
        colorSeleccionado = Color.green;
    }

    public void SeleccionarColorAzul()
    {
        colorSeleccionado = Color.blue;
    }
}
