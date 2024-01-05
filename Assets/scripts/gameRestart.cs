using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameRestart : MonoBehaviour
{
    public Button RestartButton;
    
    public void Start(){ 
        RestartButton = GetComponent<Button>();

        if (RestartButton != null)
        {
            RestartButton.onClick.AddListener(GameReStartFunction);
        }
        else
        {
            Debug.LogError("Restart Button component not found on GameObject: ");
        }
    }

    public void GameReStartFunction()
    {
        Debug.Log("New Game started.");
        SceneManager.LoadScene("mainGameScene");
    }
}
