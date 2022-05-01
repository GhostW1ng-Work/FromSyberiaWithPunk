using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpUpGiver : MonoBehaviour
{
    [SerializeField] private ItemActivator _activator;

    private bool _isJumpedUp = false;

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerMovement player) && _isJumpedUp == false)
        {
            if (_activator.ItemIsBuyed == true)
            {
                _isJumpedUp = true;
                player.JumpSpeedUp();
            }
        }

    }
}