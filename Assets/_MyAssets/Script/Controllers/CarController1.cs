using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController1 : MonoBehaviour
{
    [SerializeField] private float forwardSpeed = 10f;
    [SerializeField] private float turnSpeed = 100f;

    private Rigidbody rb;

    private void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    private void Update()
    {
        // Get steering input (A = -1, D = 1)
        //horizontal = Input.GetAxis("Horizontal");
    }
    
    public void B_Left()
    {
        horizontal = -1;
    }

    public void B_Right()
    {

        horizontal = 1;
    }

    public void B_Exit()
    {
        horizontal = 0;
    }

    float horizontal = 0;
    private void FixedUpdate()
    {
        // Always move forward with constant speed
        rb.linearVelocity = transform.forward * forwardSpeed;


        // Rotate the car smoothly
        if (horizontal != 0)
        {
            Quaternion turnOffset = Quaternion.Euler(Vector3.up * horizontal * turnSpeed * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * turnOffset);
        }
    }

    public void B_RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}