using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateRotateButton : MonoBehaviour
{
    [SerializeField] private PlatformRotate _gate;

    private void OnTriggerStay(Collider other)
    {
        if(other.TryGetComponent(out Player _player))
        {
            _gate.RotateGate();
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        _gate.BackGate();
    }
}
