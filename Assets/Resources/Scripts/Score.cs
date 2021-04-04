using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; }

    private int currentScore = 0;
    private int highScore = 0;

    public int CurrentScore { get { return currentScore; } }

    private void Awake()
    {
        if (Instance != null) return;
        else Instance = this;

        LoadHighScore();
    }

    public void AddCurrentScore(int _count)
    {
        currentScore += _count;
    }

    public void ResetCurrentScore()
    {
        currentScore = 0;
    }

    public int GetHighScore()
    {
        return highScore;
    }

    public void SetNewHighScore(int _score)
    {
        highScore = _score;
        SaveHighScore();
    }

    public void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
    }

    public void LoadHighScore()
    {
        PlayerPrefs.GetInt("HighScore", 0);
    }

}
