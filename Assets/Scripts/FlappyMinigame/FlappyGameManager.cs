using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlappyGameManager : MonoBehaviour
{
    public static FlappyGameManager instance;

    public GameObject gameOverWindow;

    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI gameOverScoreTxt;
    public TextMeshProUGUI gameOverBestScoreTxt;

    private int score = 0;
    public int Score {  get { return score; } }

    private int bestScore = 0;
    public int BestScore { get { return bestScore; } }



    private void Awake()
    {
        if (instance == null)
        {

            instance = this;
        }
    }

    private void Start()
    {
        if(PlayerPrefs.HasKey("FlappyBestScore"))
            bestScore = PlayerPrefs.GetInt("FlappyBestScore");
    }

    public void AddScore()
    {
        score++;
        if (score >= bestScore)
        {
            Debug.Log(bestScore);
            bestScore = Score;
        }
        
        scoreTxt.text = score.ToString();
    }

    public void GameEnd()
    {
        if (score == bestScore)
            PlayerPrefs.SetInt("FlappyBestScore", bestScore);
        gameOverScoreTxt.text = score.ToString();
        gameOverBestScoreTxt.text = bestScore.ToString();
        gameOverWindow.SetActive(true);
    }

    
}
