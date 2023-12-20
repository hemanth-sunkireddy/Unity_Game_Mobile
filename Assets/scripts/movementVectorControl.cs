using UnityEngine;
using System.Collections;



public class movementControlUsingVectorAndTransform : MonoBehaviour
{
    public float spawnRate = 20; 
    public float timer = 0;
    public float movementSpeed = 5f; 
    void Update()
    {
        if ( timer < spawnRate){
            timer = timer + Time.deltaTime;
        }
        else{
        Debug.Log("Right direction using velocity control and transform property.");
        transform.position = Vector3.right * movementSpeed;
        Debug.Log("Up direction using Velocity control and transform property.");
        transform.position = Vector3.up * movementSpeed;
        Debug.Log("Down direction using Velocity control and transform property");
        transform.position = Vector3.down * movementSpeed;
        Debug.Log("Left direction using Velocity control and transform property.");
        transform.position = Vector3.left * movementSpeed; 

        timer = 0;
        }

    }
}