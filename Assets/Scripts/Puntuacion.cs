using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Puntuacion : MonoBehaviour
{
   public TextMeshProUGUI textoPuntuacion;
    private int puntuacion = 0;


    void OnTriggerEnter(Collider other) // O OnCollisionEnter si los colliders no son triggers
    {
        if (other.CompareTag("ObjetoCaido"))
        {
            puntuacion++;
            Debug.Log("Puntuación: " + puntuacion); // Debug para verificar la puntuación

            if (textoPuntuacion != null)
            {
                textoPuntuacion.text = "Puntuación: " + puntuacion;
            }

            Destroy(other.gameObject);
            PuntuacionAlta.instancia.ActualizarPuntuacionAlta(puntuacion);
        }
    }
}
