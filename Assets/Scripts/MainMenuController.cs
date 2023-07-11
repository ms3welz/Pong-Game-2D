using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LinkURL()
    {
        Application.OpenURL("https://github.com/msetyo15/Pong-Game-2D");
    }
}
