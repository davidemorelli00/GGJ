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
    public int randomSpawn;
    public dogSpawnScript dogSpawnScript;

    // Start is called before the first frame update
    void Start()
    {
        randNumber.randNumberGen();
        randomSpawn = randNumber.numberRandom;
        if (randNumber.numberRandom == 1)
        {
            Instantiate(Character, spawn1, transform.rotation);
        }
        if (randNumber.numberRandom == 2)
        {
            Instantiate(Character, spawn2, transform.rotation);
        }
        if (randNumber.numberRandom == 3)
        {
            Instantiate(Character, spawn3, transform.rotation);
        }
        if (randNumber.numberRandom == 4)
        {
            Instantiate(Character, spawn4, transform.rotation);
        }
        dogSpawnScript.CharSpawn();
    }

}
