using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _coinsCount;

    public int CoinsCount => _coinsCount;

    public event UnityAction<int> CoinAdded;

    private void Awake()
    {
        CoinAdded?.Invoke(_coinsCount);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Item item))
        {
            Debug.Log("Подобран: " + item.Name);
            item.enabled = false;
        }

        if(other.TryGetComponent(out Coin coin))
        {
            _coinsCount++;
            CoinAdded(_coinsCount);
            Destroy(coin.gameObject);
        }
    }

    public void DeleteCoins(int deleteCoinsCount)
    {
        _coinsCount -= deleteCoinsCount;
        CoinAdded(_coinsCount);
    }
}
