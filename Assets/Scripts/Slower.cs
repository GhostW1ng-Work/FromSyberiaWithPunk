using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slower : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _slowRate;

    public float SlowRate => _slowRate;
}
