using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class SpawnFloor : MonoBehaviour
{
    public GameObject floorObj; // game object ref for the floor object
    public Transform spawnPosition; // spawn position for floors
    public Vector3 spawnScale; // spawn scale (not needed)
    public Vector3 BboxScale; // collision scale (not needed)
    public LayerMask floorLayerMask; // floor layer reference (not needed)
    public float timeToSpawn; // time for the floors to spawn

    private float timer; // timer 
    List<GameObject> spawnedTiles = new List<GameObject>(); // list to keep track of all floor tiles currently alive


    private void Update()
    {
        if (timer > timeToSpawn) // if the timer exceeds the time to spawn
        {
            timer = 0; // reset timer
            SpawnTile(); // spawn the tile
        }
        else // if timer doesnt exceed time to spawn
        {
            timer += Time.deltaTime; // add 0.01 to timer
        }
    }

    void SpawnTile() // function to spawn floor tile
    {
        GameObject temp = Instantiate(floorObj, spawnPosition) as GameObject; // spawn a tile and add it to temporary variable for initialisation
        temp.transform.position = spawnPosition.position; // initialise position
        temp.transform.localScale = spawnScale; // initialise scale

        spawnedTiles.Add(temp); // add floor tile to list
    }

    
}
