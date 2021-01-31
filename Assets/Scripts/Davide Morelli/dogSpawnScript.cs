using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogSpawnScript : MonoBehaviour
{
    public int randomSpawn;
    public int dogSpawn;
    public GameObject dog;
    public Vector3 spawn1;
    public Vector3 spawn2;
    public Vector3 spawn3;
    public Vector3 spawn4;
    
    // Start is called before the first frame update
    // void Start()
    public void Start()
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
}
        /*if (randomSpawn == 2)
        {
            dogSpawn = randomSpawn;
            while (dogSpawn == 2)
            {
                dogSpawn = Random.Range(1, 4);
            }

            if (dogSpawn == 1)
            {
                Instantiate(dog, spawn1, transform.rotation);
            }
            if (dogSpawn == 3)
            {
                Instantiate(dog, spawn3, transform.rotation);
            }
            if (dogSpawn == 4)
            {
                Instantiate(dog, spawn4, transform.rotation);
            }
        }


        if (randomSpawn == 3)
        {
            dogSpawn = randomSpawn;
            while (dogSpawn == 3)
            {
                dogSpawn = Random.Range(1, 2);
            }

            if (dogSpawn == 1)
            {
                Instantiate(dog, spawn1, transform.rotation);
            }
            if (dogSpawn == 2)
            {
                Instantiate(dog, spawn2, transform.rotation);
            }

        }


        if (randomSpawn == 4)
        {
            dogSpawn = Random.Range(1, 2);
            if (dogSpawn == 1)
            {
                Instantiate(dog, spawn1, transform.rotation);
            }
            if (dogSpawn == 2)
            {
                Instantiate(dog, spawn2, transform.rotation);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}*/
