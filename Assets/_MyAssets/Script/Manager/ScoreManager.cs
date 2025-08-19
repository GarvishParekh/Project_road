using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private ScoreData scoreData;

    private void OnEnable()
    {
        ActionHandler.CarOffRoad += CalculateHighscore;
    }

    private void OnDisable()
    {
        ActionHandler.CarOffRoad -= CalculateHighscore;
    }

    private void Update()
    {
        AddScore();
    }

    private void AddScore()
    {
        scoreData.currentScore += Time.deltaTime * scoreData.scoreMultiplyer;
    }

    private void CalculateHighscore()
    {
        if (scoreData.currentScore > scoreData.highScore)
        {
            PlayerPrefs.SetInt(KeyHandler.HIGHSCORE_KEY, (int)scoreData.currentScore);
        }
        ActionHandler.ChangeScene?.Invoke("GameplayScene");
    }
}
