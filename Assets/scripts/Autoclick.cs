using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Autoclick : MonoBehaviour
{
    //price management for autoclick
    [SerializeField] private TMP_Text _priceText;
    public Getpoints gp;
    public float _price;

    private void Start()
    {
        _price = 10;
    }

    void Update()
    {
        _priceText.text = _price.ToString();
    }

    public void IncreasePrice()
    {
        _price = _price * 2;
    }

    public void DecreasePoints()
    {
        if (gp._currentScore >= _price)
        {
            gp._currentScore -= _price;
        }
    }
}
