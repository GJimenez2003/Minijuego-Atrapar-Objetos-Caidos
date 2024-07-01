using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puntuacion : MonoBehaviour
{
    public Text puntuacionText;
    private int puntuacion = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjetoCaido"))
        {
            puntuacion++;
            puntuacionText.text = "Puntuación: " + puntuacion;
            Destroy(other.gameObject);
        }
    }
}
