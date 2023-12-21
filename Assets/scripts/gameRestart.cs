using UnityEngine;
using UnityEngine.SceneManagement;

public class gameRestart : MonoBehaviour
{
    void Update()
    {
        // Debug.Log("Starting New game.");
        // SceneManager.LoadScene("mainGameScene");
        // Check if the space key is pressed
        if (Input.touchCount > 0)
        {
            Debug.Log("Restarting the Game.");
            SceneManager.LoadScene("mainGameScene");
        }
    }
}
