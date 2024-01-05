using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; 
using System.Collections; 


public class score: MonoBehaviour { 
    public TMP_Text _scoreText; 
    public int playerScore = 0; 

    public void Update() { 
        _scoreText.text = "score: " + playerScore; 
        playerScore++;
    }
}