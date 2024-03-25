using UnityEngine;
using UnityEngine.Serialization;

public class BallController : MonoBehaviour
{
    public float Speed = 1f;
    public float MaxSpeed = 5f;
    public float JumpForce = 3f;
    public GameObject LosePanel;
    public GameObject WinPanel;
    private Rigidbody _rb;
    private bool _isTouchingLava, _isFinished, _isGrounded;
    private Vector3 _playerVelocity;
    private 

    void Start()
    {
        LosePanel.SetActive(false);
        WinPanel.SetActive(false);
        _isTouchingLava = false;
        _isFinished = false;
        _rb = GetComponent<Rigidbody>();
        _isGrounded = true;
    }

    void Update()
    { 
        
        if (!_isTouchingLava && !_isFinished)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(-verticalInput, 0f, horizontalInput);
            _rb.AddForce(movement * Speed);

            //speed limit
            _rb.velocity = new Vector3(
                Mathf.Clamp(_rb.velocity.x, -MaxSpeed, MaxSpeed),
                _rb.velocity.y,
                Mathf.Clamp(_rb.velocity.z, -MaxSpeed, MaxSpeed));
        }   
        
        if (_isGrounded && Input.GetButtonDown("Jump"))
        {
            _rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
        

    }
    
    void OnCollisionStay(Collision collision)
    {
        _isGrounded = true;
    }
    void OnCollisionExit(Collision collision)
    {
        _isGrounded = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lava"))
        {
            _isTouchingLava = true;
        }
        if (other.CompareTag("Finish"))
        {
            _isTouchingLava = true;
        }
    }

}