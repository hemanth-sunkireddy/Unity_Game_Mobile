using UnityEngine;

public class middleAnimalRightMotion : MonoBehaviour
{
    public float speed = 1f; // Adjust the speed as needed

    void Update()
    {
        // Calculate the movement direction based on the Horizontal input.
        Vector3 movement = new Vector2(9.8f, 0f);

        // Move the GameObject based on the calculated movement of Horizontal.
        transform.Translate(movement * speed * Time.deltaTime);
    }
}