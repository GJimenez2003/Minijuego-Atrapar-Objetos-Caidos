using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanastaController : MonoBehaviour
{
     public float speed = 10f;

    void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(move, 0, 0);
    }
}
