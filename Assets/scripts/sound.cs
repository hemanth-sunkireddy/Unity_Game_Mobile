using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro; 
using System.Collections; 


public class sound: MonoBehaviour { 
    public AudioSource audioSource;

    public void Update()
    {
        audioSource.Play();
    }
}