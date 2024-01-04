using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameRestart : MonoBehaviour
{
    public Button RestartButton;
    
    public void Start(){ 
        RestartButton = GetComponent<Button>();

        // Ensure the button component is not null
        if (RestartButton != null)
        {
            // Attach the function to the button's onClick event
            RestartButton.onClick.AddListener(GameReStartFunction);
        }
        else
        {
            Debug.LogError("Button component not found on GameObject: ");
        }
    }

    public void GameReStartFunction()
    {
        Debug.Log("New Game started.");
        SceneManager.LoadScene("mainGameScene");
    }
}
