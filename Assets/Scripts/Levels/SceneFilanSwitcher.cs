using UnityEngine;
using IJunior.TypedScenes;

public class SceneFilanSwitcher : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _needCoinsAmount;

    public void LoadFinalScene()
    {
        if (_player.CoinsCount >= _needCoinsAmount)
            Final.Load();
        else
            Debug.Log("Недостаточно средств");
    }
}
