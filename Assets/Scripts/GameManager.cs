using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject panelBackMainMenu;
    public bool gameIsPaused;

    void Start()
    {
        Time.timeScale = 1;
    }

    public void ButtonBackMainMenu()
    {
        gameIsPaused = !gameIsPaused;
        PanelBack();

    }

    public void PanelBack()
    {
        if (gameIsPaused)
        {
            panelBackMainMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            panelBackMainMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
