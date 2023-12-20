using UnityEngine;
using System.Collections;



public class RigidBody_test : MonoBehaviour
{
    public float mass;
    
    public Rigidbody2D rb;

    void Start()
    {
        Debug.Log("Changing Rigid body properties using Script code.");
        rb = GetComponent<Rigidbody2D>();
        rb.mass = mass;
    }
}