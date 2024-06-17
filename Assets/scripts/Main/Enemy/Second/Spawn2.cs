using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondEnemySpawn : MonoBehaviour
{
    public GameObject firstenemy;
    public float timer = 0;
    public float spawnRate = 3;
    public float offsetY = 0.5f; // Offset from the top corner

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
        // Get screen height in world units
        float screenHeight = Camera.main.orthographicSize * 2;
        float screenWidth = screenHeight * Camera.main.aspect;

        // Calculate random Y position within the upper half of the screen height with offsetY
        float minY = offsetY;
        float maxY = screenHeight / 2 - offsetY;
        float randomY = Random.Range(minY, maxY);

        // Determine the X position (set to the right edge of the screen)
        float spawnX = screenWidth / 2;

        // Convert screen coordinates to world coordinates
        Vector3 spawnPosition = new Vector3(spawnX, randomY, 0);

        // Create the enemy at the new random position
        GameObject newEnemy = Instantiate(firstenemy, spawnPosition, Quaternion.identity);

        Debug.Log("New enemy created at position: " + newEnemy.transform.position);
    }
}
