using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody playerRigidBody;
    private float jumpForce = 300f;

    private float topLimit = 13.5f;
    private float bottomLimit = 1f;

    private float gravityModifier = 0.75f;
    public bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

    }

    // Update is called once per frame
    void Update()
    {
       //Límite Z

        if (transform.position.y >= topLimit)
        {
            transform.position = new Vector3(transform.position.x, topLimit, transform.position.z);
        }

        //Impulso
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        //GAME OVER
        if (transform.position.y <= bottomLimit)
        {
            isGameOver = true;
            Time.timeScale = 0;
        }

    }
}
