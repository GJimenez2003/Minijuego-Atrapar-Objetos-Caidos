using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntuacionAlta : MonoBehaviour
{
    public static PuntuacionAlta instancia;
    public int puntuacionMaxima;

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GuardarPuntuacion(int puntuacion)
    {
        if (puntuacion > puntuacionMaxima)
        {
            puntuacionMaxima = puntuacion;
        }
    }
}
