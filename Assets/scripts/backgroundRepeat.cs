using UnityEngine;

public class backgroundRepeat : MonoBehaviour
{
    public float scrollSpeed = 5f;
    private float backgroundWidth;

    void Start()
    {
        SpriteRenderer backgroundRenderer = GetComponent<SpriteRenderer>();
        backgroundWidth = backgroundRenderer.bounds.size.x;
    }

    void Update()
    {
        float moveAmount = Time.deltaTime * scrollSpeed;
        transform.Translate(Vector3.left * moveAmount);

        if (transform.position.x < -backgroundWidth)
        {
            RepositionBackground();
        }
    }

    void RepositionBackground()
    {
        Vector3 newPosition = new Vector3(backgroundWidth * 2, 0, 0);
        transform.position += newPosition;
    }
}