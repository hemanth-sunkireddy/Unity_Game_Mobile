using UnityEngine;

public class UpEnemyPosition : MonoBehaviour
{
    GameObject up_enemy;

    void Start()
    {
        up_enemy = GameObject.Find("UpEnemy");
        
        if (up_enemy != null)
        {
            Camera mainCamera = Camera.main;
            Vector3 screenTopRight = new Vector3(Screen.width, Screen.height, mainCamera.nearClipPlane);
            Vector3 worldTopRight = mainCamera.ScreenToWorldPoint(screenTopRight);
            worldTopRight.z = 0; 
            worldTopRight += new Vector3(-1, -1, 0); 
            up_enemy.transform.position = worldTopRight;
        }
        else
        {
            Debug.Log("Up Enemy Not Found.");
        }
    }
}
