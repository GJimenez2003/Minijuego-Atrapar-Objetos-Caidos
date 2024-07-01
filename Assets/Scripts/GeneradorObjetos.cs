using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObjetos : MonoBehaviour
{
    public GameObject objetoCaidoPrefab;
    public float intervaloGeneracion = 2f;

    private void Start()
    {
        InvokeRepeating("GenerarObjeto", 1f, intervaloGeneracion);
    }

    void GenerarObjeto()
    {
        float xPosition = Random.Range(-5f, 5f);
        Vector3 spawnPosition = new Vector3(xPosition, 10f, 0f);
        Instantiate(objetoCaidoPrefab, spawnPosition, Quaternion.identity);
    }
}
