using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanastaController : MonoBehaviour
{
 public float velocidad = 10f; // Velocidad de movimiento de la canasta
 public GameObject canasta; // Prefab de la canasta



    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * movimientoHorizontal * velocidad * Time.deltaTime);

        // Limitar el movimiento de la canasta para que no salga de la pantalla
        Vector3 posicion = transform.position;
        posicion.x = Mathf.Clamp(posicion.x, -13f, 13f); // Ajusta los límites según tu escena
        transform.position = posicion;

        // Aplicar el color seleccionado en el menú
        canasta.GetComponent<Renderer>().material.color = ColorManager.instancia.colorSeleccionado;
    }
}
