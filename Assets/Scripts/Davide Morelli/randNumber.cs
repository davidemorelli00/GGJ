using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomNumber : MonoBehaviour
{
    public int numberRandom;
    void randNumberGen()
    {
        numberRandom = Random.Range(1, 4);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
