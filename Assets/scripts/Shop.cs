using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject _store;
    [SerializeField] private GameObject _UP1;
    [SerializeField] private GameObject _UP2;
    [SerializeField] private GameObject _UP3;
    [SerializeField] private GameObject _UP4;

    public void StoreActivate()
    {
        _store.SetActive(true);
    }

    public void CloseStore()
    {
        _store.SetActive(false);
    }

    public void ColorChange1()
    {
        _UP1.GetComponent<Image>().color = Color.green;
    }
    public void ColorChange2()
    {
        _UP2.GetComponent<Image>().color = Color.green;
    }
    public void ColorChange3()
    {
        _UP3.GetComponent<Image>().color = Color.green;
    }
    public void ColorChange4()
    {
        _UP4.GetComponent<Image>().color = Color.green;
    }

}
