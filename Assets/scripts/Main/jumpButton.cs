// Attach this script to your button GameObject.

using UnityEngine;
using UnityEngine.UI;

public class jumpButton : MonoBehaviour
{
    public Button jumpArrow;

    public Rigidbody2D m_Rigidbody;

    public float jumpAmount = 10;

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

        if (m_Rigidbody != null)
        {
            m_Rigidbody.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
        else
        {
            Debug.LogError("Rigidbody2D component not assigned to m_Rigidbody on GameObject: " + gameObject.name);
        }
    }
}
