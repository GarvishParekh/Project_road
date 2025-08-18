using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Target & Offset")]
    public Transform target;                 // The thing to follow
    public Vector3 offset = new Vector3(0f, 5f, -8f);

    [Header("Smoothing")]
    public float positionSmoothTime = 0.15f; // Lower = snappier, higher = smoother
    public float rotationLerpSpeed = 6f;     // How fast the camera rotates to look at target

    [Header("Options")]
    public bool lookAtTarget = true;         // Rotate to face the target

    private Vector3 _velocity;               // For SmoothDamp

    void LateUpdate()
    {
        if (!target) return;

        // Smooth position
        Vector3 desiredPos = target.position + target.TransformDirection(offset);
        transform.position = Vector3.SmoothDamp(transform.position, desiredPos, ref _velocity, positionSmoothTime);

        // Smooth rotation (optional)
        if (lookAtTarget)
        {
            Quaternion desiredRot = Quaternion.LookRotation(target.position - transform.position, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, desiredRot, rotationLerpSpeed * Time.deltaTime);
        }
    }
}
