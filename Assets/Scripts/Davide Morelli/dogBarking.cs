using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class dogBarking : MonoBehaviour
{
    public int random;
  //  public AudioSource abbaio;
   // public AudioSource pianto;
    public GameObject Script;

    // Update is called once per frame
    void OnEnable()
    {
        StartCoroutine(Bau());
        IEnumerator Bau()
        {
            random = Random.Range(1, 10);
            yield return new WaitForSecondsRealtime(Random.Range(6f, 8f));
            
            if (random > 5)
            {
               // abbaio.Play();
                Debug.Log("abbaia");
            }

            if (random < 5)
            {
                //pianto.Play();
                Debug.Log("piange");
            }
            random = 0;
            Script.SetActive(false);
        }
    }
}
