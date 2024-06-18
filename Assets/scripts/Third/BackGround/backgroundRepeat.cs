using UnityEngine;



public class backgroundRepeat : MonoBehaviour
{
    public float scrollSpeed = 5f;
    public float backgroundWidth;

    public void Start()
    {
        SpriteRenderer backgroundRenderer = GetComponent<SpriteRenderer>();
        backgroundWidth = backgroundRenderer.bounds.size.x;
    }

    public void Update()
    {
        float moveAmount = Time.deltaTime * scrollSpeed;
        transform.Translate(Vector3.left * moveAmount);
    }
}