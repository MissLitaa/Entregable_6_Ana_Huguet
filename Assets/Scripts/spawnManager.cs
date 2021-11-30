using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    //Object array.
    public GameObject spawnPrefabs;

    //Script connection.
    private playerController playerControllerScript;

    //Initial pose.
    private Vector3 initialRotation = Vector3.zero;

    //Spawn preferences.

    private float spawnDelay = 2f;
    private float spawnRate = 1f;
    private Vector3 spawnHeight;
    private int rotationY = 180;
    
    

    //Spawn axis.
    private float spawnPosition = -14f;
    private float randomHeight;
    private float topLimit = 13.5f;
    private int rValue;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<playerController>();

        //Debido a que la instanciación modifica el prefab fuerzo éste a siempre aparecer en rotación "zero".

        if (!playerControllerScript.isGameOver)
        {
            gameObject.transform.rotation *= Quaternion.Euler(initialRotation);
        }

        InvokeRepeating("SpawnObstaclePrefab", spawnDelay, spawnRate);
    }

    private void Update()
    {
        
    }

    private void SpawnObstaclePrefab()
    { 
        randomHeight = Random.Range(0, topLimit);
        rValue = Random.Range(0, 2);

            if (rValue == 1)
            {
                spawnPrefabs.transform.rotation *= Quaternion.Euler(0, rotationY, 0);
                spawnHeight = new Vector3(spawnPosition, randomHeight, 0);
            }

            else if (rValue == 0)
            {
                spawnPrefabs.transform.rotation *= Quaternion.Euler(Vector3.zero);
                spawnHeight = new Vector3(-spawnPosition, randomHeight, 0);
            }

        Instantiate(spawnPrefabs, spawnHeight, spawnPrefabs.transform.rotation );
   
    }
}
