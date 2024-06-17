using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondEnemyMovement : MonoBehaviour
{   
    public float speed = 1f; 

    void Update()
    {
        Vector3 movement = new Vector2(-9.8f, 0f);
        transform.Translate(movement * speed * Time.deltaTime);
    }

}
