using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameStart : MonoBehaviour
{
    public Button StartButton;
    
    public void Start(){ 
        StartButton = GetComponent<Button>();

        // Ensure the button component is not null
        if (StartButton != null)
        {
            // Attach the function to the button's onClick event
            StartButton.onClick.AddListener(GameStartFunction);
        }
        else
        {
            Debug.LogError("Button component not found on GameObject: ");
        }
    }

    public void GameStartFunction()
    {
        Debug.Log("New Game started.");
        SceneManager.LoadScene("mainGameScene");
    }
}
