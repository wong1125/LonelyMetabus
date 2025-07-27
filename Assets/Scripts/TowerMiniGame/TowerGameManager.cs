using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TowerGameManager : MonoBehaviour
{
    public static TowerGameManager instance;

    float score = 0;
    float bestScore;

    public GameObject gameOverWindow;

    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI gameOverScoreTxt;
    public TextMeshProUGUI gameOverBestScoreTxt;


    bool isGameOver = false;
    public bool IsGameOver {  get { return isGameOver; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey("TowerBestScore"))
            bestScore = PlayerPrefs.GetFloat("TowerBestScore");
    }

    public void GameOver()
    {
        isGameOver = true;

        if (score == bestScore)
            PlayerPrefs.SetFloat("TowerBestScore", bestScore);
        gameOverScoreTxt.text = score.ToString("N1");
        gameOverBestScoreTxt.text = bestScore.ToString("N1");
        gameOverWindow.SetActive(true);

    }
}
