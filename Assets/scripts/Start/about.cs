using UnityEngine;
using TMPro;

public class about : MonoBehaviour
{
    public TMP_Text _aboutText;
    public float posY = -30f;
    public float offsetX = 1000f; 

    void Start()
    {
        RectTransform rt = _aboutText.GetComponent<RectTransform>();

        rt.anchorMin = new Vector2(0, 0);
        rt.anchorMax = new Vector2(0, 0);
        rt.pivot = new Vector2(0, 0);
        float screenWidth = Screen.width;
        rt.anchoredPosition = new Vector2(screenWidth / 4, 400);
    }
}
