using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

[System.Serializable]
public class HighScoreData
{
    public int highScore;
}
public class PuntuacionAlta : MonoBehaviour
{
    public static PuntuacionAlta instancia;
    public int highScore = 0;
    public TextMeshProUGUI highScoreText;


    private string rutaArchivo;

    void Awake()
    {
        // Singleton
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        rutaArchivo = Application.persistentDataPath + "/highscore.json";
        CargarPuntuacion();
    }

    public void ActualizarPuntuacionAlta(int nuevaPuntuacion)
    {
        if (nuevaPuntuacion > highScore)
        {
            highScore = nuevaPuntuacion;
            GuardarPuntuacion();
            ActualizarTextoPuntuacionAlta();
        }
    }

    void CargarPuntuacion()
    {
        if (File.Exists(rutaArchivo))
        {
            string json = File.ReadAllText(rutaArchivo);
            HighScoreData datos = JsonUtility.FromJson<HighScoreData>(json);
            highScore = datos.highScore;
            ActualizarTextoPuntuacionAlta();
        }
    }

    void GuardarPuntuacion()
    {
        HighScoreData datos = new HighScoreData();
        datos.highScore = highScore;
        string json = JsonUtility.ToJson(datos);
        File.WriteAllText(rutaArchivo, json);
    }

    void ActualizarTextoPuntuacionAlta()
    {
        highScoreText.text = "Puntuación más alta: " + highScore;
    }
}
