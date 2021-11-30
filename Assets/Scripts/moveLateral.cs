using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLateral : MonoBehaviour
{
    private float obstacleSpeed = 10;
    private float limitX = 20f;
    private float limitX2 = -40f;
    private playerController playerControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
       if (!playerControllerScript.isGameOver)
        {
            transform.Translate(Vector3.right * obstacleSpeed * Time.deltaTime);
        }

        if (transform.position.x > limitX)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < limitX2)
        {
            Destroy(gameObject);
        }




    }
}
