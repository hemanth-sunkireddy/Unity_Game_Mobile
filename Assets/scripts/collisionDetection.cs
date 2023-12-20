using UnityEngine;

public class CollisionDetection2D : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision involves the specific Rigidbody2D you are interested in
        Debug.Log("Collision Detected");
    }
}
