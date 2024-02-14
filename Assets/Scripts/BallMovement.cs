using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody rb;
    public float maxSpeed = 5f;
    public GameObject losePanel, winPanel;
    private bool isTouchingLava, isFinished;

    void Start()
    {
        losePanel.SetActive(false);
        winPanel.SetActive(false);
        isTouchingLava = false;
        isFinished = false;
        rb = GetComponent<Rigidbody>();        
    }

    void Update()
    {
        if (!isTouchingLava && !isFinished)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(-verticalInput, 0f, horizontalInput);
            rb.AddForce(movement * speed);

            //speed limit
            rb.velocity = new Vector3(
                Mathf.Clamp(rb.velocity.x, -maxSpeed, maxSpeed),
                rb.velocity.y,
                Mathf.Clamp(rb.velocity.z, -maxSpeed, maxSpeed));
        }        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lava"))
        {
            isTouchingLava = true;
        }
        if (other.CompareTag("Finish"))
        {
            isTouchingLava = true;
        }
    }

}