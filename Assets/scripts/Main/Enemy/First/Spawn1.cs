using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstEnemySpawn : MonoBehaviour
{
    public GameObject firstenemy;
    public float timer = 0;
    public float spawnRate = 3;

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
        float screenHeight = Camera.main.orthographicSize * 2;
        float screenWidth = screenHeight * Camera.main.aspect;
        float minY = -(screenHeight/2) + 0.5f;
        float maxY = 0;
        float randomY = Random.Range(minY, maxY);
        float spawnX = screenWidth / 2;
        
        Vector3 spawnPosition = new Vector3(spawnX, randomY, 0);
        GameObject newEnemy = Instantiate(firstenemy, spawnPosition, Quaternion.identity);

        Debug.Log("New enemy created at position: " + newEnemy.transform.position);
    }
}
