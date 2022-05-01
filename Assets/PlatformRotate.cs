using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlatformRotate : MonoBehaviour
{
    [SerializeField] private AudioSource _gateAudio;
    [SerializeField] private AudioClip _gateAudioClip;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            RotateGate();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            BackGate();
        }

    }

    public void RotateGate()
    {
        transform.DOLocalRotate(new Vector3(0,90,0), 10);
    }

    public void BackGate()
    {
        transform.DOLocalRotate(new Vector3(0, 0, 0), 10);
    }

    public void GatePlayAudio()
    {
        _gateAudio.PlayOneShot(_gateAudioClip);
    }
}
