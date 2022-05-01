using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Transform _startPosition;

    private void Update()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.TryGetComponent(out Limitor limitor))
        {
            transform.position = new Vector3(0,0,0);
        }
    }

}
