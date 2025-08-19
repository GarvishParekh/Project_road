using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    [Header("<b>Scriptables")]
    [SerializeField] private InputData inputData;

    [Space]
    [SerializeField] private float forwardSpeed = 10f;
    [SerializeField] private float turnSpeed = 100f;

    private Rigidbody rb;

    private void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    private void FixedUpdate()
    {
        // Always move forward with constant speed
        rb.linearVelocity = transform.forward * forwardSpeed;


        // Rotate the car smoothly
        if (inputData.horizontalInputs != 0)
        {
            Quaternion turnOffset = Quaternion.Euler(Vector3.up * inputData.horizontalInputs * turnSpeed * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * turnOffset);
        }
    }
    public void B_RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}