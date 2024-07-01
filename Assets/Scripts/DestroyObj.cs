using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
   void Update()
    {
        if (transform.position.y < -10f) // Ajusta el límite según tu escena
        {
            Destroy(gameObject);
        }
    }
}
