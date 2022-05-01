using UnityEngine;
using IJunior.TypedScenes;
public class SwitchToLevel1 : MonoBehaviour
{
    [SerializeField] private int _needCoinsAmount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            if (player.CoinsCount >= _needCoinsAmount)
            {
                player.DeleteCoins(_needCoinsAmount);
                TestScene.Load();
            }
            else
            {
                Debug.Log("оюьнк мюуси");
            }
        }
    }
}
