using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{

    public void End()
    {
        Application.Quit();
    }
    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
