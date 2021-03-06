﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    private int score;
    private int highScore;
    private string highScoreKey = "highScore";
    void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        score = 0;

        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }

    public void AddPoint(int point)
    {
        score += point;

        Debug.Log(score);

        if(highScore < score)
        {
            highScore = score;
            Debug.Log(highScore);
        }

        DisplayScores();
    }

    private void DisplayScores()
    {
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
    }

    public void Save()
    {
        PlayerPrefs.SetInt(highScoreKey, highScore);
        PlayerPrefs.Save();

        Initialize();
    }
}
