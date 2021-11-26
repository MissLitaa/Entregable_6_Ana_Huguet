using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    //Object array.
    public GameObject[] spawnPrefabs;

    //Spawn preferences.
    public float spawnDelay = 5f;
    public float spawnRate = 3f;
    public string[] spawnSide;

    //Spawn axis.
    public float spawnLeft = -10f;
    public float spawnRight = 10f;
    public float spawnHeight;
   

    private float topLimit = 13.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnHeight = Random.Range(0, topLimit);
       
    }
    
    private void SpawnObstaclePrefab()
    {
        /*
        {
            spawnCount = Random.Range(0, spawnPrefabs.Length);
            Instantiate(spawnPrefabs[spawnCount]), new Vector3()
        }*/
    }
}
