using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * PlayerController.cs
 * Assignment 5
 * This controls the player movement.
 */

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float moveSpeed = 15;
    public float xRange = 20;
    public float zRange = 8;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.back * horizontalInput * Time.deltaTime * moveSpeed);
        transform.Translate(Vector3.right * verticalInput * Time.deltaTime * moveSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Vehicle"))
        {
            gameObject.SetActive(false);
            gameManager.gameOver();
        }
    }
}
