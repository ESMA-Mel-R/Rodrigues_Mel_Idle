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
    [SerializeField] private GameObject _Aura;

    public float _currentScore;
    public float _addScore;
    private bool _auto;
    private int _autoPerSec;
    private int _aSpeed;

    private float _autoprice;
    private float _multiprice;
    private int _autoBoost;
    private int _multiboost;

    private bool _upgrade1;
    private bool _upgrade2;
    private bool _upgrade3;
    private bool _upgrade4;

    public bool _randomBoost;
    public GameObject _boosterButton;
    private float _ran;

    private void Start()
    {
        _aSpeed = 1;
        _currentScore = 0;
        _addScore = 1;
        _autoPerSec = 0;
        _auto = false;
        _autoprice = 20;
        _multiprice = 30;
        _autoBoost = _aSpeed;
        _multiboost = 1;
        _upgrade1 = false;
        _upgrade2 = false;
        _upgrade3 = false;
        _upgrade4 = false;
        _ran = 30f;
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

        //booster setup
        //deactivate the event button when the condition is false and starts the waiting script
        if (_randomBoost == false && _boosterButton.activeInHierarchy == true)
        {
            _boosterButton.SetActive(false);
            StartCoroutine(WaitForEvent());
        }

        //activate the event button when the condition is true
        if (_randomBoost == true && _boosterButton.activeInHierarchy == false)
        {
            _boosterButton.SetActive(true);
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
            _multiprice += 30;
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
            _autoprice += 20;
        }
    }

    public void Booster()
    {
        StartCoroutine(Boost());
        StartCoroutine(WaitForEvent());
    }

    IEnumerator WaitForEvent()
    {
        yield return new WaitForSeconds(_ran);

        int x = 0;
        x = Random.Range(1, 3);

        if (x == 2)
        {
            _randomBoost = true;
        }
        else
        {
            _boosterButton.SetActive(true);
        }
    }

    //script for random booster
    IEnumerator Boost()
    {
        _randomBoost = false;
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        _Aura.SetActive(true);
        _autoBoost = _aSpeed * 2;
        _multiboost = 2;
        yield return new WaitForSeconds(10);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        _Aura.SetActive(false);
        _autoBoost = _aSpeed;
        _multiboost = 1;
    }

    //upgrades from the shop
    public void MultiplicatorUpgrade()
    {
        if (!_upgrade1 && _currentScore >= 250)
        {
            _currentScore -= 250;
            _addScore = _addScore * 2;
            _upgrade1 = true;
        }
    }

    public void AutoScoreUpgrade()
    {
        if (!_upgrade2 && _currentScore >= 500)
        {
            _currentScore -= 500;
            _autoPerSec = _autoPerSec * 2;
            _upgrade2 = true;
        }
    }

    public void AutoSpeedUpgrade()
    {
        if (!_upgrade3 && _currentScore >= 1000)
        {
            _currentScore -= 1000;
            _aSpeed = _aSpeed * 2;
            _upgrade3 = true;
        }
    }

    public void BoostFrequencyUpgrade()
    {
        if (!_upgrade4 && _currentScore >= 1500)
        {
            _currentScore -= 1500;
            _ran = _ran / 2;
            _upgrade4 = true;
        }
    }
}
