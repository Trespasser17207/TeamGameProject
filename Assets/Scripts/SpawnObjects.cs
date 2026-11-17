using NUnit.Framework;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnObjects : MonoBehaviour
{
    public GameObject roadblock; // game object ref for roadblock
    public GameObject cone; // game object ref for cone
    public GameObject cluster; // game object ref for cluster of cones and roadblocks
    public GameObject coin; // game object ref for coins

    public Transform spawnPos; // spawn position for cones and roadblocks
    public Transform coinSpawnPos; // spawn position for coins
    public Transform clusterPos; // spawn position for cluster of cones and roadblocks
    public float maxRandomTime; // the maximum random time for objects to spawn
    public float minRandomTime; // the minimum random time for objects to spawn

    private float spawnTimer; // timer counting up in milliseconds 
    private float decidedMaxTime; // the random time decided after every object

    List<GameObject> spawnedObjects = new List<GameObject>(); // list for all objects spawned (unused)

    private void Start()
    {
        RandomiseTimer(); // immediately randomise the timer with values given
    }

    void RandomiseTimer() // function for randomising the timer
    {
        decidedMaxTime = Random.Range(minRandomTime, maxRandomTime); // random float inbetween the minimum and maximum value given
    }
    private void Update()
    {
        if (spawnTimer > decidedMaxTime) // on tick, check if the spawn timer and exceeded the decided random time
        {
            int chance = Random.Range(1, 6); // random temporary integer inbetween 1 and 6 
            if (chance <= 3) // spawn a coin if temp value is less than or equal to 3
            {
                SpawnCoin(); // spawn coin
            }
            spawnTimer = 0f; // reset timer
            SpawnObject(); // spawn object
        }
        else // if timer hasnt exceeded the decided random time
        {
            spawnTimer += Time.deltaTime; // increment timer by 0.01
        }
    }

    void SpawnObject() // function for spawning timer
    {
        int decision = Random.Range(1, 12); // temporary value for deciding what object type to spawn
        if (decision < 4) // if temp valuse is less than 4
        {
            GameObject temp = Instantiate(cluster) as GameObject; // spawn cluster
            temp.transform.position = clusterPos.position; // set cluster position to spawn point
            spawnedObjects.Add(temp); // add object to list
        }
        else if (decision >= 4 && decision < 8) // if temp value is greater than or equal to 4 and less than 8
        {
            GameObject temp = Instantiate(roadblock) as GameObject; // spawn roadblock 
            temp.transform.position = spawnPos.position; // set roadblock position to spawn point
            spawnedObjects.Add(temp); // add object to list
        }
        else if (decision >= 8 && decision < 12) // if temp value is greater or equal to 8 and less than 12
        {
            GameObject temp = Instantiate(cone) as GameObject; // spawn cone
            temp.transform.position = spawnPos.position; // set cone position to span position
            spawnedObjects.Add(temp); // add object to list
        }
        decidedMaxTime = Random.Range(minRandomTime, maxRandomTime); // randomise time again
    }


    void SpawnCoin() // function for spawning coin
    {
        GameObject coinTemp = Instantiate(coin) as GameObject; // spawn coin as game object
        coinTemp.transform.position = coinSpawnPos.position; // set coin position to coin spawn position
    }
}


