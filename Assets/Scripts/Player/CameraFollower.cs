using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _smoothSpeed;
    [SerializeField] private Vector3 _offset;

    private void LateUpdate()
    {
        Vector3 desiredPosition = _player.transform.position + _offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, _smoothSpeed);
        transform.position = smoothedPosition;
    }

}
