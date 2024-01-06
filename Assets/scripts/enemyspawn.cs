using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    public GameObject enemy; 
    public float timer = 0; 
    
    public float speed = 1f; 

    public float spawnRate = 5; 

    // Update is called once per frame
    public void Update()
    {
        if ( timer < spawnRate ){

            timer = timer + Time.deltaTime; 
        }
        else{
            enemyGenerate();
            timer = 0; 
        }
    }

    public void enemyGenerate(){

        Instantiate(enemy, transform.position, transform.rotation);

        Debug.Log("New enemy created to the game.");

    }
}
