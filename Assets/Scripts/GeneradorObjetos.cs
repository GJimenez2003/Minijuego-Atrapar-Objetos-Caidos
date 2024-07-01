using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GeneradorObjetos : MonoBehaviour
{
    public GameObject[] objetosPrefab; // Array de prefabs de objetos que caen
    public float intervalo = 1f; // Intervalo de tiempo entre la generación de objetos

    void Start()
    {
        InvokeRepeating("GenerarObjeto", 0f, intervalo); // Llamar a GenerarObjeto cada 'intervalo' segundos
    }

    void GenerarObjeto()
    {
        int indiceAleatorio = Random.Range(0, objetosPrefab.Length);
        Instantiate(objetosPrefab[indiceAleatorio], new Vector3(Random.Range(-8f, 8f), 6f, 0f), Quaternion.identity); 
        // Instanciar un objeto aleatorio en una posición x aleatoria y en la parte superior de la pantalla
    }


}
