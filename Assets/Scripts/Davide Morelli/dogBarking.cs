using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class dogBarking : MonoBehaviour
{
    public int random;
    public int randomSound;
    public GameObject abbaio1;
    public GameObject abbaio2;
    public GameObject abbaio3;

    public GameObject pianto1;
    public GameObject pianto2;
    public GameObject pianto3;
    public GameObject Script;

    // Update is called once per frame
    void OnEnable()
    {
        
        StartCoroutine(Bau());
        IEnumerator Bau()
        {
            random = Random.Range(1, 10);
            yield return new WaitForSecondsRealtime(Random.Range(3f, 8f));
            
            if (random > 5)
            {
                randomSound = Random.Range(1, 3);
                if(randomSound == 1)
                {
                    abbaio1.SetActive(true);
                    yield return new WaitForSecondsRealtime(1f);
                    abbaio1.SetActive(false);

                }
                if (randomSound == 2)
                {
                    abbaio2.SetActive(true);
                    yield return new WaitForSecondsRealtime(1f);
                    abbaio2.SetActive(false);

                }
                if (randomSound == 3)
                {
                    abbaio3.SetActive(true);
                    yield return new WaitForSecondsRealtime(1f);
                    abbaio3.SetActive(false);

                }

                Debug.Log("abbaia");
            }

            if (random < 5)
            {
                randomSound = Random.Range(1, 3);
                if (randomSound == 1)
                {
                    pianto1.SetActive(true);
                    yield return new WaitForSecondsRealtime(1f);
                    pianto1.SetActive(false);

                }
                if (randomSound == 2)
                {
                    pianto2.SetActive(true);
                    yield return new WaitForSecondsRealtime(1f);
                    pianto2.SetActive(false);
                }
                if (randomSound == 3)
                {
                    pianto3.SetActive(true);
                    yield return new WaitForSecondsRealtime(1f);
                    pianto3.SetActive(false);

                }
                Debug.Log("piange");
            }
            random = 0;
            randomSound = 0;
            Script.SetActive(false);
        }

    }
}
