using UnityEngine;

public class BottomEnemyPosition : MonoBehaviour
{
    GameObject bottom_enemy;

    void Start()
    {
        bottom_enemy = GameObject.Find("BottomEnemy");

        if (bottom_enemy != null)
        {
            Camera mainCamera = Camera.main;
            float screenHeight = Screen.height;
            float screenWidth = Screen.width;
            Vector3 screenBottomRight = new Vector3(screenWidth, 0, mainCamera.nearClipPlane);
            Vector3 worldBottomRight = mainCamera.ScreenToWorldPoint(screenBottomRight);
            worldBottomRight.z = 0; 
            worldBottomRight += new Vector3(-1, 1, 0); 
            bottom_enemy.transform.position = worldBottomRight;
        }
        else
        {
            Debug.Log("Bottom Side Enemy Not Found.");
        }
    }
}
