using UnityEngine;

public class movementControlWithRigidBodyAffect : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed

    private Rigidbody2D middleSquare;

    void Start()
    {
        // Get the Rigidbody component attached to the GameObject
        middleSquare = GetComponent<Rigidbody2D>();

        // Make sure the Rigidbody is not affected by gravity when moving in the horizontal direction
        // middleSquare.useGravity = false;
    }

    void Update()
    {
        // Get the horizontal input (left and right arrow keys, A and D keys, or joystick)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Get the vertical input (up and down arrow keys, W and S keys, or joystick)
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction based on the input.
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);

        // Apply the movement to the Rigidbody
        middleSquare.velocity = movement * speed;
    }
}
