using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Getpoints : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _autopriceText;
    [SerializeField] private TMP_Text _multipriceText;
    private float _currentScore;
    private float _addScore;
    private bool _auto;
    private int _autoPerSec;
    private float _autoprice;
    private float _multiprice;
    private int _autoBoost;
    private int _multiboost;

    private void Start()
    {
        _currentScore = 0;
        _addScore = 1;
        _autoPerSec = 0;
        _auto = false;
        _autoprice = 5;
        _multiprice = 10;
        _autoBoost = 1;
        _multiboost = 1;
    }

    private void Update()
    {
        _autopriceText.text = _autoprice.ToString();
        _multipriceText.text = _multiprice.ToString();
        _scoreText.text = _currentScore.ToString("$ " + "0");

        //update according to autoclick
        if (_auto)
        {
            _currentScore += _autoPerSec * Time.deltaTime * _autoBoost;
        }
    }

    //mulitplier increasing the score of the clicks
    public void IncreaseScore()
    {
        _currentScore = _currentScore + _addScore * _multiboost;
    }
    
    //setting of multiplier button : increase the gain each time it's clicked
    public void MultiplierScore()
    {
        if (_currentScore >= _multiprice)
        {
            _addScore += 1;
            _currentScore -= _multiprice;
            _multiprice += 5;
        }
    }

    //activate autoclick the first time and increase each click
    public void AutoClickUpgrade()
    {
        if (_currentScore >= _autoprice)
        {
            _auto = true;
            _currentScore -= _autoprice;
            _autoPerSec += 1;
            _autoprice += 5;
        }
    }

    public void Booster()
    {
        StartCoroutine(Boost());
    }

    IEnumerator Boost()
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        _autoBoost = 2;
        _multiboost = 2;
        yield return new WaitForSeconds(5);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        _autoBoost = 1;
        _multiboost = 1;
    }
}
