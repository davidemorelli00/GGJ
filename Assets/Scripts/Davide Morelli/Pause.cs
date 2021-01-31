using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool gameIsPaused;
    public GameObject Canvas;
    public GameObject options;
    public GameObject menu;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
    }
    public void Options()
    {
        menu.SetActive(false);
        options.SetActive(true);
    }

    public  void Menu()
    {
        options.SetActive(false);
        menu.SetActive(true);
    }

    public void NoPause()
    {
        gameIsPaused = !gameIsPaused;
        PauseGame();
    }

    void PauseGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            menu.SetActive(true);
            options.SetActive(false);
        }
        else
        {
            Time.timeScale = 1;
            menu.SetActive(false);
            options.SetActive(false);
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
}

