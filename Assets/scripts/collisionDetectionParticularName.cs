using UnityEngine;

public class CollisionDetectionUsingGameObjectName2D : MonoBehaviour
{
    public string targetObjectName = "bottomSquare"; // Set the name of the GameObject you want to detect collisions with
    public string targetObjectTag = "firstTag"; // Set the name of the GameObject you want to detect collisions with


    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision involves the specific GameObject by comparing names
        if (collision.gameObject.tag == targetObjectTag)
        {
            Debug.Log("Collision Detected with bottom square.");
            
        }
    }
}
