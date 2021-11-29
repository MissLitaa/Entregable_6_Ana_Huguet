using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    //Object array.
    public GameObject[] spawnPrefabs;

    //Spawn preferences.
    private float spawnDelay = 5f;
    private float spawnRate = 3f;
    private int spawnCount = 1;
    private Vector3 spawnHeight;
    private int rotationY = 180;

    //Spawn axis.
    public float spawnPosition = -10f;
    private float randomHeight;
    private float topLimit = 13.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randomHeight = Random.Range(0, topLimit);
        spawnHeight = new Vector3(randomHeight, 0, 0);
    }
    
    private void SpawnObstaclePrefab()
    {
        
        {
            Instantiate(spawnPrefabs[spawnCount], spawnHeight, spawnPrefabs[spawnCount].transform.rotation *= Quaternion.Euler(0, rotationY, 0));
        }
    }
}
