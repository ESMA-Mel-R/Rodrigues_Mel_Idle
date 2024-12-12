using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickAndAuto : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _priceText;
    public float _currentScore;
    public float _addScore;
    private bool _auto;
    private int _autoPerSec;
    public float _autoprice;

    private void Start()
    {
        _currentScore = 0;
        _addScore = 1;
        _autoPerSec = 0;
        _auto = false;
        _autoprice = 10;
    }

    private void Update()
    {
        _priceText.text = _autoprice.ToString();

        //update according to autoclick
        if (_auto)
        {
            _currentScore += _autoPerSec * Time.deltaTime;
        }
        _scoreText.text = _currentScore.ToString("0");
    }

    //mulitplier increasing the score of the clicks
    public void IncreaseScore()
    {
        _currentScore = _currentScore + _addScore;
    }

    //setting of multiplier button : increase the gain each time it's clicked
    public void MultiplierScore()
    {
        _addScore += 1;
    }

    public void AutoClickUpgrade()
    {
        if (_currentScore >= _autoprice)
        {
            _auto = true;
            _currentScore -= _autoprice;
            _autoPerSec += 1;
            _autoprice += 10;
        }
    }
}
