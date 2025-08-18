using UnityEngine;

public class LevelIdentitiy : MonoBehaviour
{
    LevelManager levelManager;
    [SerializeField] private Transform endPointTransform;

    private void Start()
    {
        levelManager = LevelManager.instance;
    }

    private void UpdatePosition()
    {
        transform.position = levelManager.GetLevelSpwanerPosition();
        levelManager.SetLevelSpwanerPosition(endPointTransform.position);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag ("Player"))
        {
            UpdatePosition();
        }
    }
}
