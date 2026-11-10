using NUnit.Framework;
using System.Runtime.CompilerServices;
using UnityEngine;
using System.Collections.Generic;

public class SpawnObjects : MonoBehaviour
{
    public GameObject roadblock;
    public GameObject cone;
    public GameObject cluster;

    public Transform spawnPos;
    public Transform clusterPos;
    public float maxRandomTime;
    public float minRandomTime;

    private float spawnTimer;
    private float determineRandTimer;
    private float decidedMaxTime;

    List<GameObject> spawnedObjects = new List<GameObject>();

    private void Start()
    {
        RandomiseTimer();
    }

    void RandomiseTimer()
    {
        decidedMaxTime = Random.Range(minRandomTime, maxRandomTime);
    }
    private void Update()
    {
        if (spawnTimer > decidedMaxTime) 
        {
            spawnTimer = 0f;
            SpawnObject();
        }
        else
        {
            spawnTimer += Time.deltaTime;
        }
    }

    void SpawnObject()
    {
        int decision = Random.Range(1, 12);
        if (decision < 4)
        {
            GameObject temp = Instantiate(cluster) as GameObject;
            temp.transform.position = clusterPos.position;
            spawnedObjects.Add(temp);
        }
        else if (decision >= 4 && decision < 8) 
        {
            GameObject temp = Instantiate(roadblock) as GameObject;
            temp.transform.position = spawnPos.position;
            spawnedObjects.Add(temp);
        }
        else if (decision >= 8 && decision < 12)
        {
            GameObject temp = Instantiate(cone) as GameObject;
            temp.transform.position = spawnPos.position;
            spawnedObjects.Add(temp);
        }
    }
}


