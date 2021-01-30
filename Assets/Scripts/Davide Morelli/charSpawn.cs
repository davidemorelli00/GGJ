using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charSpawn : MonoBehaviour
{
    public GameObject Character;
    public Vector3 spawn1;
    public Vector3 spawn2;
    public Vector3 spawn3;
    public Vector3 spawn4;
    public randNumber randNumber;
    private int randomSpawn;

    // Start is called before the first frame update
    void Start()
    {
        randNumber.randNumberGen();
        randomSpawn = randNumber.numberRandom;
        if (randomSpawn == 1)
        {
            Instantiate(Character, spawn1, transform.rotation);
        }
        if (randomSpawn == 2)
        {
            Instantiate(Character, spawn2, transform.rotation);
        }
        if (randomSpawn == 3)
        {
            Instantiate(Character, spawn3, transform.rotation);
        }
        if (randomSpawn == 4)
        {
            Instantiate(Character, spawn4, transform.rotation);
        }
    }


}
