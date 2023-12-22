using UnityEngine;
using UnityEngine.UI;

public class UpButton : MonoBehaviour
{
    // Attach this script to your button GameObject

    public float speed = 5f; // Adjust the speed as needed
    private Button myButton;

    public Rigidbody2D m_Rigidbody;

    private void Start()
    {
        // Get the Button component attached to this GameObject
        myButton = GetComponent<Button>();

        // Ensure the button component is not null
        if (myButton != null)
        {
            // Attach the function to the button's onClick event
            myButton.onClick.AddListener(UpMovementFunction);
        }
        else
        {
            Debug.LogError("Button component not found on GameObject: ");
        }

        // You may want to assign m_Rigidbody through the inspector, or find it in the scene
        // Example: m_Rigidbody = GameObject.Find("YourTargetGameObjectName").GetComponent<Rigidbody2D>();
    }

    // Function to be executed when the button is clicked
    private void UpMovementFunction()
    {
        // Your code to be executed on button click goes here
        // Calculate the movement direction based on the Vertical input.
        Vector2 movement = new Vector2(0f, 9.8f);

        // Check if the Rigidbody2D component is not null
        if (m_Rigidbody != null)
        {
            // Move the Rigidbody2D based on the calculated movement
            m_Rigidbody.velocity = movement * speed;
        }
        else
        {
            Debug.LogError("Rigidbody2D component not assigned to m_Rigidbody on GameObject: " + gameObject.name);
        }
    }
}
