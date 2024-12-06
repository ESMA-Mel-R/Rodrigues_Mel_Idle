using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Autoclick : MonoBehaviour
{
    [SerializeField] private TMP_Text _priceText;
    public Getpoints gp;
    public float _price;
    public float _gain;
    private bool active;

    private void Start()
    {
        _price = 10;
        _gain = 0;
        active =false;
    }

    void Update()
    {
        _priceText.text = _price.ToString();
        if (active)
        {
            gp._currentScore += _gain;
        }
    }

    public void IncreasePrice()
    {
        _price = _price * 2;
    }

    public void DecreasePoints()
    {
        gp._currentScore -= _price;
    }

    public void AutoStart()
    {
        active = true;
        _gain += 1;
    }
}
