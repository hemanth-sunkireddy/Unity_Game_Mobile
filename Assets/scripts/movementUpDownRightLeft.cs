using UnityEngine;

public class MoveLeftRightUpDown : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed

    void Update()
    {
        // Get the horizontal input (left and right arrow keys, A and D keys, or joystick)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Get the Vertical input (up and down arrow keys, W and S keys, or joystick)
        float verticalInput = Input.GetAxis("Vertical");


        // Calculate the movement direction based on the Horizontal input.
        Vector3 movement = new Vector2(horizontalInput, 0f);

       // Calculate the movement direction based on the Vertical input. 
        Vector3 movement2 = new Vector2(0f, verticalInput);


        // Move the GameObject based on the calculated movement of Horizontal.
        transform.Translate(movement * speed * Time.deltaTime);

        // Move the GameObject based on the calculated movement of Vertical.
        transform.Translate(movement2 * speed * Time.deltaTime);

    }
}