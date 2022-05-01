using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpGiver : MonoBehaviour
{
    [SerializeField] private ItemActivator _activator;

    private bool _isSpeededUp = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out PlayerMovement player) && _isSpeededUp == false)
        {
            if(_activator.ItemIsBuyed == true)
            {
                _isSpeededUp = true;
                player.MoveSpeedUp();
            }
        }
        
    }
}
