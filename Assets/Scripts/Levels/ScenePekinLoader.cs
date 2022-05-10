using UnityEngine;
using IJunior.TypedScenes;

public class ScenePekinLoader : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private int _needCoinsAmount;

    public void LoadPekinScene()
    {
        if (_player.CoinsCount >= _needCoinsAmount)
            Pekin.Load();
        else
            Debug.Log("Недостаточно средств");
    }
}
