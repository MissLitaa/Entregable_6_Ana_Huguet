using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLateral : MonoBehaviour
{
    public float obstacleSpeed;
    public float limitX = 14;
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
    }
}
