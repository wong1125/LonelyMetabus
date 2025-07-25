using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlappyGameManager : MonoBehaviour
{
    public static FlappyGameManager instance;

    public GameObject gameOverWindow;

    public TextMeshProUGUI scoreTxt;

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


    public void AddScore()
    {
        score++;
        if (score >= bestScore)
        {
            bestScore = Score;
        }
        
        scoreTxt.text = score.ToString();
    }

    public void GameEnd()
    {
        gameOverWindow.SetActive(true);
    }

    
}
