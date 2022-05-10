using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class SceneParisSwitcher : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _needCoinsAmount;

    public void LoadParisScene()
    {
        if (_player.CoinsCount >= _needCoinsAmount)
            Paris2.Load();
        else
            Debug.Log("Недостаточно средств");
    }
}
