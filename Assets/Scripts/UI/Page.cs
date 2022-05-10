using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page : MonoBehaviour
{
    [SerializeField] private GameObject[] _pages;
    [SerializeField] private int _index;

    private void Update()
    {

    }

    public void NextPage()
    {
        if(_index < _pages.Length)
        {
            _index++;
            _pages[_index].SetActive(true);
        }
        if(_index -1 > 0)
        {
            _pages[_index - 1].SetActive(false);
        }
    }
}
