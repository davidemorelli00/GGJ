using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButtonInstructions : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("game");
    }
}
