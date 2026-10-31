using UnityEngine;
using TMPro; 

public class Counter : MonoBehaviour
{
    private int score;
    private TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        score = 0;
        TextUpdate();
    }

    public void IncreaseCounter() 
    {
        score += 1;
        TextUpdate();
    }

    void TextUpdate()
    {
        text.text = $"Times grabbed {score}";
    }
}
