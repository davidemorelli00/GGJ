using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class instructionsScript : MonoBehaviour
{
    public GameObject istruzioni;
    public GameObject comandi;
public void fwd()
    {
        istruzioni.SetActive(false);
        comandi.SetActive(true);
    }
    public void startGame()
    {
        SceneManager.LoadScene("ScenaDavide");
    }
}
