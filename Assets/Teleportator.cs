using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportator : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player player))
        {
            Debug.Log("”пал");
            player.transform.position = new Vector3(-8, 6,-189);
        }
    }
}
