using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Getpoints : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    public float _currentScore;
    private float _addScore;

    private void Start()
    {
        _currentScore = 0;
        _addScore = 1;
    }

    private void Update()
    {
        _scoreText.text = _currentScore.ToString();
    }

    public void IncreaseScore()
    {
        _currentScore = _currentScore + _addScore;
    }
    
    public void MultiplierScore()
    {
        _addScore += 1;
    }
}
