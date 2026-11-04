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

    List<GameObject> spawnedTiles = new List<GameObject>(); // list to keep track of all floor tiles currently alive

    private void Start()
    {
        SpawnTile();
    }

    void SpawnTile()
    {
        GameObject temp = Instantiate(floorObj, spawnPosition) as GameObject; // spawn a tile and add it to temporary variable for initialisation
        temp.transform.position = spawnPosition.position; // initialise position
        temp.transform.localScale = spawnScale; // initialise scale
        
        spawnedTiles.Add(temp);
    }

    void checkSafety()
    {
        /*
         * Add code here for checking if the spanwers colider is not intersecting with any floors
         * if it is empty (no intersections) spawn a tile
         * if there is an intersection wait until there isnt 
         */
    }
}
