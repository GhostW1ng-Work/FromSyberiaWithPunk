using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GateRotateButton : MonoBehaviour
{
    [SerializeField] private PlatformRotate _gate;
    [SerializeField] private AudioClip _buttonClip;

    private UnityAction ButtonClicked;

    private void OnEnable()
    {
        ButtonClicked += OnButtonClicked;
    }

    private void OnDisable()
    {
        ButtonClicked -= OnButtonClicked;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player _player))
        {
            _gate.RotateGate();
            ButtonClicked?.Invoke();
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        _gate.BackGate();
        ButtonClicked?.Invoke();
    }

    public void OnButtonClicked()
    {
        AudioSource.PlayClipAtPoint(_buttonClip, transform.position);
    }
}
