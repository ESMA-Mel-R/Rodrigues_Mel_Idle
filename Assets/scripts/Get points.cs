using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Getpoints : MonoBehaviour
{
    [SerializeField] private TMP_Text score;
    private float currentScore;
    private float addScore;

    private void Start()
    {
        currentScore = 0;
        addScore = 1;
    }

    private void Update()
    {
        score.text = currentScore.ToString();
    }

    public void IncreaseScore()
    {
        currentScore = currentScore + addScore;
    }
    
    public void MultiplierScore()
    {
        addScore += 1;
    }
}
