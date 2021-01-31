using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider playerFound)
    {
        if (playerFound.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("ScenaDavide");
        }
    }
}
