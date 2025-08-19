using UnityEngine;

[CreateAssetMenu (fileName = "Score data", menuName = "Scriptable/Score data")]
public class ScoreData : ScriptableObject
{
    public float currentScore = 0;
    public float highScore = 0;
    public float scoreMultiplyer = 0;
}
