using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody playerRigidBody;
    private float jumpForce = 300f;

    private float topLimit = 13.5f;
    private float bottomLimit = 1f;

    private AudioSource playerAS;

    public AudioClip jumpBlip;
    public AudioClip explosionClip;

    public ParticleSystem bombExplode;

    private float gravityModifier = 0.75f;
    public bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAS = GetComponent<AudioSource>();
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
        if (Input.GetKeyDown(KeyCode.Space) && !isGameOver)
        {
            playerRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            playerAS.PlayOneShot(jumpBlip, 1f);
        }

        //GAME OVER
        if (transform.position.y <= bottomLimit)
        {
            isGameOver = true;
            Time.timeScale = 0;
        }

    }

    private void OnCollisionEnter(Collision otherCollision)
    {
        if (!isGameOver)
        {
            if (otherCollision.gameObject.tag == "Bomb")
            {
                bombExplode.Play();
                playerAS.PlayOneShot(explosionClip, 1f);
                isGameOver = true;
                bombExplode.Stop();
            }

        }

    }
}
