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
    private bool safeToSpawn;

    private bool safety = false;

<<<<<<< Updated upstream
    List<GameObject> spawnedTiles = new List<GameObject>(); // list to keep track of all floor tiles currently alive
=======
    private void Start()
    {
        SpawnTile();
    }

>>>>>>> Stashed changes
    void SpawnTile()
    {
        GameObject temp = Instantiate(floorObj, spawnPosition) as GameObject; // spawn a tile and add it to temporary variable for initialisation
        temp.transform.position = spawnPosition.position; // initialise position
        temp.transform.localScale = spawnScale; // initialise scale

        spawnedTiles.Add(temp);
    }
<<<<<<< Updated upstream

    private void CheckSafety()
    {
        if (Physics.Raycast(transform.position, Vector3.back, out RaycastHit hit, transform.localScale.z / 2))
        {
            if (hit.collider.gameObject.tag == "floor")
            {
                safety = false;
            }
        }
        else
        {
            safety = true;
        }

    }
=======
>>>>>>> Stashed changes
}
