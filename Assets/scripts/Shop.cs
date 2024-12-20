using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject _store;

    public void StoreActivate()
    {
        _store.SetActive(true);
    }

    public void CloseStore()
    {
        _store.SetActive(false);
    }

    
}
