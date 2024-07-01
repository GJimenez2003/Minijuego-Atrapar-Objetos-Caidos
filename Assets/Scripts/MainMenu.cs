using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Dropdown colorDropdown;

    public void StartGame()
    {
        PlayerPrefs.SetInt("BasketColor", colorDropdown.value);
        SceneManager.LoadScene("GameScene");
    }
}
