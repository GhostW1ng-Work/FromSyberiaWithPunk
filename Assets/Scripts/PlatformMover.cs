using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlatformMover : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOLocalMove(_targetPosition, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
