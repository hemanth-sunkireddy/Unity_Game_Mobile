using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy; 
    public float timer = 0; 
    public float speed = 1f; 
    public float spawnRate = 3; 

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            enemyGenerate();
            timer = 0;
        }
    }

    public void enemyGenerate()
    {
        GameObject newEnemy = Instantiate(enemy, transform.position, transform.rotation);

        // If the enemy is a UI element, adjust its RectTransform
        RectTransform rt = newEnemy.GetComponent<RectTransform>();
        if (rt != null)
        {
            rt.anchorMin = new Vector2(1, 1);
            rt.anchorMax = new Vector2(1, 1);
            rt.pivot = new Vector2(1, 1);
            rt.anchoredPosition = new Vector2(-20, -20); // Offset from top-right corner
        }
        else
        {
           Debug.Log("Enemy Not Found");
        }

        Debug.Log("New enemy created in the game.");
    }
}
