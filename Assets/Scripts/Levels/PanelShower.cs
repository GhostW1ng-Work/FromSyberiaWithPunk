using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelShower : MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player player))
        {
            _panel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _panel.SetActive(false);
    }

    public void ClosePanel()
    {
        _panel.SetActive(false);
    }
}
