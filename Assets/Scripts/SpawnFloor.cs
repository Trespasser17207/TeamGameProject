using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class SpawnFloor : MonoBehaviour
{
    public GameObject floorObj;
    public Transform spawnPosition;
    public Vector3 spawnScale;
    public Vector3 BboxScale;
    public LayerMask floorLayerMask;
    public float timeToSpawn;

    private float timer;
    private bool safety = true;
    List<GameObject> spawnedTiles = new List<GameObject>(); // list to keep track of all floor tiles currently alive


    private void Update()
    {
        if (timer > timeToSpawn)
        {
            timer = 0;
            SpawnTile();
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    void SpawnTile()
    {
        GameObject temp = Instantiate(floorObj, spawnPosition) as GameObject; // spawn a tile and add it to temporary variable for initialisation
        temp.transform.position = spawnPosition.position; // initialise position
        temp.transform.localScale = spawnScale; // initialise scale

        spawnedTiles.Add(temp);
    }

    
}
