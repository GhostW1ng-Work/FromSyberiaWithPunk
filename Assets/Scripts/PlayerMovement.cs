using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _currentMoveSpeed;
    [SerializeField] private Camera _camera;
    [SerializeField] private float _targetMoveSpeed;
    [SerializeField] private float _speedLimit;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _jumpSpeed;
    [SerializeField] private float _speedSum;
    [SerializeField] private float _jumpSpeedSum;
    [SerializeField] private AudioClip _jumpSound;

    private CharacterController _characterController;
    private float _ySpeed;
    private float _originalStepOffset;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _originalStepOffset = _characterController.stepOffset;
        _currentMoveSpeed = _targetMoveSpeed;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude) * _currentMoveSpeed;
        movementDirection.Normalize();

        _ySpeed += Physics.gravity.y * Time.deltaTime;

        if (_characterController.isGrounded)
        {
            _characterController.stepOffset = _originalStepOffset;
            _ySpeed = -0.5f;

            if (Input.GetButtonDown("Jump"))
            {
                AudioSource.PlayClipAtPoint(_jumpSound, _camera.transform.position, 100);
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

    private void OnTriggerStay(Collider other)
    {
        if(other.TryGetComponent(out Slower slower) && _currentMoveSpeed > _speedLimit )
        {
            _currentMoveSpeed -= slower.SlowRate;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _currentMoveSpeed = _targetMoveSpeed;
    }

    public void MoveSpeedUp()
    {
        _targetMoveSpeed += _speedSum;
        _currentMoveSpeed = _targetMoveSpeed;
    }

    public void JumpSpeedUp()
    {
        _jumpSpeed += 5;
    }

}
