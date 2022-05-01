using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class SceneEgyptSwitcher : MonoBehaviour
{
    [SerializeField] private int _needCoinsAmount;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player player))
        {
            if(player.CoinsCount >= _needCoinsAmount)
            {
                player.DeleteCoins(_needCoinsAmount);
                Egypt.Load();
            }
            else
            {
                Debug.Log("оюьнк мюуси");
            }
        }
    }
}
