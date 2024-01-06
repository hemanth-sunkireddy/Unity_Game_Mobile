using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    public GameObject enemy; 
    public int initial_time = 0; 
    
    public float speed = 1f; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( initial_time == 1000 ){
            enemyGenerate();
            initial_time = 0; 
        }
        initial_time++;
    }

    public void enemyGenerate(){
        Instantiate(enemy, transform.position, transform.rotation);

        // Calculate the movement direction based on the Horizontal input.
        Vector2 movement = new Vector2(9.8f, 0f);

        // Move the GameObject based on the calculated movement of Horizontal.
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
