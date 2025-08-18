using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    [SerializeField] private Transform levelSpawner;

    private void Awake()
    {
        instance = this;
    }

    public Vector3 GetLevelSpwanerPosition()
    {
        return levelSpawner.position;
    }

    public void SetLevelSpwanerPosition(Vector3 newPos)
    {
        levelSpawner.position = newPos;
    }
}
