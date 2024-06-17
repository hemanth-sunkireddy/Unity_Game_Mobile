using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public Button StartButton;
    
    public void Start(){ 
        StartButton = GetComponent<Button>();
        RectTransform rt = StartButton.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0, 0);
        rt.anchorMax = new Vector2(0, 0);
        rt.pivot = new Vector2(0, 0);
        float screenWidth = Screen.width;

        Debug.Log(screenWidth);
        rt.anchoredPosition = new Vector2(screenWidth / 4, 50);

        if (StartButton != null)
        {
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
