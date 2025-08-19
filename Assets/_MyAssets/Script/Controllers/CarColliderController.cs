using UnityEngine;

public class CarColliderController : MonoBehaviour
{
    [SerializeField] private string roadSideTagString;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag (roadSideTagString))
        {
            Debug.Log("Hit road side");
            ActionHandler.CarOffRoad?.Invoke();
        }
    }
}
