using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class score : MonoBehaviour
{
    public int playerScore = 1;

    public float timer = 0;

    public float spawnRate = 3;

    public TMP_Text _scoreText;

    void Start()
    {
        RectTransform rt = _scoreText.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0, 1);
        rt.anchorMax = new Vector2(0, 1);
        rt.pivot = new Vector2(0, 1);
        rt.anchoredPosition = new Vector2(30, -30); 
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            scoreUpdate();
            timer = 0;
        }
    }

    void scoreUpdate()
    {
        _scoreText.text = "Score: " + playerScore;
        playerScore++;
    }
}
