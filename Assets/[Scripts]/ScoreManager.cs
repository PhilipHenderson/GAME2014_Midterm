////////////////////////////////////////
//
// Created By: Philip Henderson
// Student Number: 101137744
//
// Date Last Modified: October 22nd/2022
//
//
// Source File: GAME2014-Midterm-101137744
// Program: Video Game Programming
//
// Revision History: Changed the Core framework:
//  - Player is placed on the left side of the screen
//  - Player looking and shooting to the right
//  - Enemies placed on the right side instead of the top
//  - Enemies movement change from right-left to up-down
//
////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[System.Serializable]
public class ScoreManager : MonoBehaviour
{
    private TMP_Text scoreLabel;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreLabel = GameObject.Find("ScoreLabel").GetComponent<TMP_Text>();
        SetScore(0);
    }

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int newScore)
    {
        score = newScore;
        UpdateScoreLabel();
    }

    public void AddPoints(int points)
    {
        score += points;
        UpdateScoreLabel();
    }

    public void UpdateScoreLabel()
    {
        scoreLabel.text = $"Score: {score}";
    }
}
