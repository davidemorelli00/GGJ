using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogSpawnScript : MonoBehaviour
{
    public int randomSpawn;
    public GameObject dog;
    public Vector3 spawn1;
    public Vector3 spawn2;
    public Vector3 spawn3;
    public Vector3 spawn4;
    // Start is called before the first frame update
    void Start()
    {
        randomSpawn = Random.Range(1, 4);
        if (randomSpawn == 1)
        {
            Instantiate(dog, spawn1, transform.rotation);
        }
        if (randomSpawn == 2)
        {
            Instantiate(dog, spawn2, transform.rotation);
        }
        if (randomSpawn == 3)
        {
            Instantiate(dog, spawn3, transform.rotation);
        }
        if (randomSpawn == 4)
        {
            Instantiate(dog, spawn4, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
