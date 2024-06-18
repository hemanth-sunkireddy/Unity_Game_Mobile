using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class select : MonoBehaviour
{
    public Button selectButton;
    
    public void Start(){ 
        selectButton = GetComponent<Button>();

        if (selectButton != null)
        {
            selectButton.onClick.AddListener(GameStartFunction);
        }
        else
        {
            Debug.LogError("Button component not found on GameObject: ");
        }
    }

    public void GameStartFunction()
    {
        Debug.Log("New Game started.");
        SceneManager.LoadScene("Third");
    }
}
