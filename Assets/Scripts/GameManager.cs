using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
     public void VolverAlMenu()
    {
        SceneManager.LoadScene("MenuScene"); // Carga la escena del menú
    }
}

