using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    private TextMeshProUGUI ScoreText;
    public int score = 0;

    private void Awake()
    {
        ScoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        RefreshUI();
    }

    public void IncreaseScore(int increment)
    {
        score += increment;
        RefreshUI();
    }

    public void RefreshUI()
    {
        string text = "Score: " + score;
        ScoreText.text = (score < 30) ?  text : text + "\n \nAll 3 Keys are collected !!";
    }
}
