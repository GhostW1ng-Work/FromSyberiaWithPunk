using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemActivator : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PanelShower _panelShower;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private GameObject _item;
    [SerializeField] private int _itemCost;

    private bool _itemIsBuyed = false;

    private void Update()
    {
        
    }

    public void BuySpeedUp()
    {
        if(_player.CoinsCount >= _itemCost && _itemIsBuyed == false)
        {
            _itemIsBuyed = true;
            _item.gameObject.SetActive(true);
            _player.DeleteCoins(_itemCost);
            _playerMovement.MoveSpeedUp();
            _panelShower.ClosePanel();
            _panelShower.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Проваливай");
        }
    }

    public void BuyJumpUp()
    {
        if (_player.CoinsCount >= _itemCost && _itemIsBuyed == false)
        {
            _itemIsBuyed = true;
            _item.gameObject.SetActive(true);
            _player.DeleteCoins(_itemCost);
            _playerMovement.JumpSpeedUp();
            _panelShower.ClosePanel();
            _panelShower.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Проваливай");
        }
    }
}
