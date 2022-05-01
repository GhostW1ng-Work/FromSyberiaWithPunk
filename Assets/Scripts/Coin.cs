using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private ParticleSystem _coin;

    private void OnDestroy()
    {
        Instantiate(_coin, gameObject.transform.position, Quaternion.identity);
        _coin.Play();
    }
}
