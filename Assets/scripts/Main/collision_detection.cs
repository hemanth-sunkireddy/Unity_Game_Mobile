using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionDetectionUsingGameObjectName2D : MonoBehaviour
{
    public string targetObjectTag = "enemy"; 

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == targetObjectTag)
        {
            Debug.Log("Collision Detected with the enemy. Game Over");
            SceneManager.LoadScene("endGameScene");
        }
    }
}

