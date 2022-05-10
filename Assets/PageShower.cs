using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageShower : MonoBehaviour
{
    [SerializeField] private GameObject _paper;
    [SerializeField] private GameObject _text;

    private void OnTriggerEnter(Collider other)
    {
        _paper.gameObject.SetActive(true);
        _text.gameObject.SetActive(false);
    }


}
