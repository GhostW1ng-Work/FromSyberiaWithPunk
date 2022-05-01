using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Vector3 _startRotation;
    [SerializeField] private float _smoothSpeed = 0.125f;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private Vector3 _velocity = Vector3.zero;

    private void Start()
    {
       transform.rotation = Quaternion.Euler(_startRotation);
    }

    void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, _player.position + _offset, ref _velocity, _smoothSpeed * Time.deltaTime);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.RotateAround(_player.position, Vector3.up, _rotateSpeed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(_player.position, -Vector3.up, _rotateSpeed * Time.deltaTime);
        }

        else
        {
            transform.rotation = Quaternion.Euler(_startRotation);
        }
    }
}

