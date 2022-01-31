using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    private TextMeshProUGUI ScoreText;
    private int score = 0;

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

    private void RefreshUI()
    {
        string text = "Score: " + score;
        ScoreText.text = (score < 30) ?  text : text + "\nAll 3 Keys are collected !! \n LEVEL COMPLETED";
    }
}
