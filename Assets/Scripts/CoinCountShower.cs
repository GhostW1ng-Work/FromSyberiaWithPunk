using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCountShower : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsCountText;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.CoinAdded += OnCoinAdded;
    }

    private void OnDisable()
    {
        _player.CoinAdded -= OnCoinAdded;
    }

    private void OnCoinAdded(int coinsAmount)
    {
        _coinsCountText.text = coinsAmount.ToString();
    }
}
