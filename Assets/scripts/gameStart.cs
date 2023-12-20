using UnityEngine;
using UnityEngine.SceneManagement;

public class gameStart : MonoBehaviour
{
    void Update()
    {
        // Debug.Log("Starting New game.");
        // SceneManager.LoadScene("mainGameScene");
        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space)  || Input.touchCount > 0)
        {
            Debug.Log("New Game started.");
            SceneManager.LoadScene("mainGameScene");
        }
    }
}
