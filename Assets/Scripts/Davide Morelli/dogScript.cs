using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dogScript : MonoBehaviour
{
    public bool vittoria = false;
    public void OnTriggerEnter(Collider playerFound)
    {
        if (playerFound.gameObject.CompareTag("Player"))
        {
            vittoria = true;
        }
    }
    private void Update()
    {
        if (vittoria == true)
        {
            SceneManager.LoadScene("aaaa");
        }
    }
    // Update is called once per frame

}
