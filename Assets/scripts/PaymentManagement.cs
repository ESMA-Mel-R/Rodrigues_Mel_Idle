using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class PaymentManagement : MonoBehaviour
{
    //price management for multiplier
    [SerializeField] private TMP_Text _priceText;
    public Getpoints gp;
    public float _price;

    private void Start()
    {
        _price = 5;
    }

    private void Update()
    {
        _priceText.text = _price.ToString();
    }

    public void IncreasePrice()
    {
        _price = _price *2; 
    }

    public void DecreasePoints()
    {
        gp._currentScore -= _price;
    }
}
