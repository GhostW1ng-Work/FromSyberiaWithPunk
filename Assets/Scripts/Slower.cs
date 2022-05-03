using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slower : MonoBehaviour
{
    [SerializeField] private float _slowRate;

    public float SlowRate => _slowRate;
}
