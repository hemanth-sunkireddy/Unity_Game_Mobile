using UnityEngine;

public class AlignCharacter : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        // Check if the Rigidbody2D component is attached
        rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            Debug.Log("Rigidbody2D found.");
        }
        else
        {
            Debug.LogError("Rigidbody2D not found!");
            return; // Exit if Rigidbody2D is not found
        }

        // Attempt to find the main camera
        if (Camera.main != null)
        {
            Debug.Log("Main camera found.");
            AlignToLeftHalfCenter();
        }
        else
        {
            Debug.LogError("Main camera not found!");
        }
    }

    void AlignToLeftHalfCenter()
    {
        // Calculate the screen center for the left half of the screen
        Vector3 screenCenterLeftHalf = new Vector3(Screen.width / 4f, Screen.height / 2f, Camera.main.nearClipPlane);

        // Log the screen position
        Debug.Log("Screen center left half: " + screenCenterLeftHalf);

        // Convert screen coordinates to world coordinates
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(screenCenterLeftHalf);

        // Log the world position
        Debug.Log("World position: " + worldPosition);

        // Set the character's position to the calculated world position
        rb.position = new Vector3(worldPosition.x, worldPosition.y);

        // Log the new position of the character
        Debug.Log("Character new position: " + rb.position);
    }
}
