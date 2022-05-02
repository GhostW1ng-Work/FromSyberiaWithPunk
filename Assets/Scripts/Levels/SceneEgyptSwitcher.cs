using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class SceneEgyptSwitcher : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _needCoinsAmount;

    public void LoadEgyptScene()
    {
        if (_player.CoinsCount >= _needCoinsAmount)
            Egypt.Load();
        else
            Debug.Log("Недостаточно средств");   
    }
}
