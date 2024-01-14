using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; 
using System.Collections; 


public class score: MonoBehaviour { 

    public int playerScore = 1; 

    public float timer = 0; 
    
    public float spawnRate = 3; 

    public TMP_Text _scoreText; 

    public void Update()
    {
        if ( timer < spawnRate ){
            timer = timer + Time.deltaTime; 
        }
        else{
            scoreUpdate();
            timer = 0; 
        }
    }

    public void scoreUpdate() { 
        _scoreText.text = "Score: " + playerScore; 
        playerScore++;
    }
}