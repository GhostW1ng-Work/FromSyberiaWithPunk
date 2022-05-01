using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _jumpSpeed;
    [SerializeField] private float _speedSum;
    [SerializeField] private float _jumpSpeedSum;

    private CharacterController _characterController;
    private float _ySpeed;
    private float _originalStepOffset;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _originalStepOffset = _characterController.stepOffset;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude) * _moveSpeed;
        movementDirection.Normalize();

        _ySpeed += Physics.gravity.y * Time.deltaTime;

        if (_characterController.isGrounded)
        {
            _characterController.stepOffset = _originalStepOffset;
            _ySpeed = -0.5f;

            if (Input.GetButtonDown("Jump"))
            {
                _ySpeed = _jumpSpeed;
            }
        }
        else
        {
            _characterController.stepOffset = 0;
        }

        Vector3 velocity = movementDirection * magnitude;
        velocity.y = _ySpeed;

        _characterController.Move(velocity * Time.deltaTime);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, _rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            MoveSpeedUp();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            JumpSpeedUp();
        }
    }

    public void MoveSpeedUp()
    {
        _moveSpeed += _speedSum;
    }

    public void JumpSpeedUp()
    {
        _jumpSpeed += 5;
    }
}
