using TMPro;
using UnityEngine;

public class GameplayScoreController : MonoBehaviour
{
    [Header ("<b>Scriptable")]
    [SerializeField] private ScoreData scoreData;

    [Header("<b>User interface ")]
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highScoreText;

    private void Start()
    {
        scoreData.currentScore = 0;
        UpdatehighscoreUi();
    }

    private void Update()
    {
        UpdateScoreUi();
    }

    private void UpdateScoreUi()
    {
        scoreText.text = $"SCORE: {scoreData.currentScore.ToString("00000")}";
    }

    private void UpdatehighscoreUi()
    {
        scoreData.highScore = PlayerPrefs.GetInt(KeyHandler.HIGHSCORE_KEY, 0);
        highScoreText.text = $"HIGHSCORE: {scoreData.highScore.ToString("00000")}";
    }
}
