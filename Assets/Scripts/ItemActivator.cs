using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemActivator : MonoBehaviour
{
    [SerializeField] private GameObject _item;
    [SerializeField] private int _itemCost;

    private bool _itemIsBuyed = false;

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player player))
        {
            if (_itemIsBuyed == false)
            {
                if (player.CoinsCount >= _itemCost)
                {
                    _itemIsBuyed = true;
                    _item.gameObject.SetActive(true);
                    player.DeleteCoins(_itemCost);
                }
                else
                {
                    Debug.Log("Нищеброд");
                }
            }
            else
            {
                Debug.Log("Ты уже купил!!!");
            }
        }
    }

}
