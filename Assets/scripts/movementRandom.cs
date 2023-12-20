using UnityEngine;
using UnityEngine.SceneManagement; 
using System;

public class ContinuousRandomMovement : MonoBehaviour
{
    public float speed = 1f; 

    private Rigidbody2D randomObject;

    public string targetObjectTag = "mainAnimal"; // Set the name of the GameObject you want to detect collisions with


    void Start()
    {
        randomObject = GetComponent<Rigidbody2D>();

        // Make sure random object is not affected by Gravity.
        randomObject.gravityScale = 0f;
    }

    void Update()
    {
        // Generate a random integer between 1 and 10 (inclusive)
        int randomNumber = UnityEngine.Random.Range(1, 100);
        // Debug.Log("Random Number between 1 and 10: " + randomNumber);
        if ( randomNumber < 5){
            // Calculate the movement direction based on the input.
            Vector3 movement = new Vector3(9.8f, 0f, 0f);

            // Apply the movement to the Rigidbody
            randomObject.velocity = movement * speed;
        }
        else if ( randomNumber < 10){
            // Calculate the movement direction based on the input.
            Vector3 movement = new Vector3(0f, 9.8f, 0f);

            // Apply the movement to the Rigidbody
            randomObject.velocity = movement * speed;
        }
        else if ( randomNumber < 15){
            Vector3 movement = new Vector3(-9.8f, 0f, 0f); 

            randomObject.velocity = movement * speed; 
        }
        else if(randomNumber < 20){ 
            Vector3 movement = new Vector3(0f, -9.8f, 0f);

            randomObject.velocity = movement * speed; 
        }    
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision involves the specific GameObject by comparing names
        if (collision.gameObject.tag == targetObjectTag)
        {
            Debug.Log("Collision Detected with bottom square.");

            SceneManager.LoadScene("endGameScene");
            
        }
    }
}