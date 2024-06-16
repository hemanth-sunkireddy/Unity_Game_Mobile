using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_repeat : MonoBehaviour
{
    public GameObject backgroundImage; 
    public float timer = 0; 

    public float spawnRate = 3; 

    public void Start() { 
        backgroundGenerate();
    }

    // Update is called once per frame
    public void Update()
    {
        if ( timer < spawnRate ){

            timer = timer + Time.deltaTime; 
        }
        else{
            backgroundGenerate();
            timer = 0; 
        }
    }

    public void backgroundGenerate(){
        Instantiate(backgroundImage, transform.position, transform.rotation);
    }
}
