using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] private int _needCoinsAmount;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player player))
        {
            if(player.CoinsCount >= _needCoinsAmount)
            {
                player.DeleteCoins(_needCoinsAmount);
                Level1.Load();
            }
            else
            {
                Debug.Log("оюьнк мюуси");
            }
        }
    }
}
