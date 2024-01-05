// Attach this script to your button GameObject.

using UnityEngine;
using UnityEngine.UI;

public class jumpButton : MonoBehaviour
{
    public float speed = 5f; 
    public Button jumpArrow;

    public Rigidbody2D m_Rigidbody;

    public void Start()
    {
        jumpArrow = GetComponent<Button>();

        if (jumpArrow != null)
        {
            jumpArrow.onClick.AddListener(UpMovementFunction);
        }
        else
        {
            Debug.LogError("Button component not found on GameObject: ");
        }
    }

    public void UpMovementFunction()
    {
        Vector2 movement = new Vector2(0f, 9.8f);

        if (m_Rigidbody != null)
        {
            m_Rigidbody.velocity = movement * speed;
        }
        else
        {
            Debug.LogError("Rigidbody2D component not assigned to m_Rigidbody on GameObject: " + gameObject.name);
        }
    }
}
