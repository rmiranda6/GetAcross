using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject player;

    public float movementSpeed;
    public float rotationSpeed;
    public int health = 3;
    public AudioSource hitSound;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        health = 3;

    }

    void Update()
    {

        playerMovement();

    }

    void playerMovement()
    {
        //Moves the camera left and right along with the player
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime, 0);
        //Moves the player forward, backwards and left and right
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed, 0, 0);
        if(Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed * 1.5f); // Makes the player run
        }

    }

    public void Health()
    {
        health -= 1; // player loses health
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            hitSound.Play(); // When the player hits a cow, a hit sound will play
        }
    }





}
