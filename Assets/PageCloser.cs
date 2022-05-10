using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageCloser : MonoBehaviour
{
    [SerializeField] private GameObject _page;

    public void ClosePage()
    {
        _page.gameObject.SetActive(false);
    }
}
