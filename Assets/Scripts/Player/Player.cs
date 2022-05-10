using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _coinsCount;
    [SerializeField] private Camera _camera;
    [SerializeField] private AudioClip _audio;
    [SerializeField] private Vector3 _standartPosition;

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
            AudioSource.PlayClipAtPoint(_audio, _camera.transform.position, 100);
            _coinsCount++;
            Destroy(coin.gameObject);
            CoinAdded(_coinsCount);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = _standartPosition;
        }
    }

    public void DeleteCoins(int deleteCoinsCount)
    {
        _coinsCount -= deleteCoinsCount;
        CoinAdded(_coinsCount);
    }
}
