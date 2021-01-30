using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class dogScript : MonoBehaviour
{
    public bool vittoria = false;
    public dogBarking dogBarking;
    public GameObject dogSound;
    public void OnTriggerEnter(Collider playerFound)
    {
        if (playerFound.gameObject.CompareTag("Player"))
        {
            vittoria = true;
        }
    }
     void Update()
    {
        if (vittoria == true)
        {
            SceneManager.LoadScene("aaaa");
        }
        dogSound.SetActive(true);
    }
    // Update is called once per frame

}
