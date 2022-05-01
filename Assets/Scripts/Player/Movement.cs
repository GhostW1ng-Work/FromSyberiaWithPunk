using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _rotationSpeed;

    private Rigidbody _rigidBody;
    private Vector3 _inputVector;
    private float _ySpeed;


    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        _ySpeed += Physics.gravity.y * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _ySpeed = _jumpForce;
        }

        _inputVector = new Vector3(horizontal, _rigidBody.velocity.y, vertical);
        transform.LookAt(transform.position + new Vector3(_inputVector.x, 0, _inputVector.z));
    }

    private void FixedUpdate()
    {
        _rigidBody.velocity = _inputVector * _moveSpeed * Time.fixedDeltaTime;
    }
}
