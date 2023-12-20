using UnityEngine;
using UnityEngine.SceneManagement;

public class gameRestart : MonoBehaviour
{
    void Update()
    {
        // Debug.Log("Starting New game.");
        // SceneManager.LoadScene("mainGameScene");
        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Restarting the Game.");
            SceneManager.LoadScene("mainGameScene");
        }
    }
}
