using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TowerGameManager : MonoBehaviour
{
    public static TowerGameManager instance;

    GameObject highestBlock;

    float score = 0;
    public float Score { get { return score; } }

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

    private void Update()
    {
        if (!isGameOver)
            CalculateScore();
    }

    public void SetHighestBlock(GameObject block)
    {
        if (highestBlock == null)
        {

            highestBlock = block;
        }
        else
        {
            float newHeight = BoundHeightCalcaulte(block);
            float orignHeight = BoundHeightCalcaulte(highestBlock);

            if (newHeight > orignHeight)
                highestBlock = block;
        }

        if (highestBlock != null)
            Debug.Log("블록 세팅");

    }

    void CalculateScore()
    {
        if(highestBlock != null)
        {
            float blockHeigt = BoundHeightCalcaulte(highestBlock);
            Debug.Log(blockHeigt);
            if (blockHeigt > score)
            {
                score = blockHeigt;
                scoreTxt.text = score.ToString("N1");
            }
        }

        if (score >= bestScore)
        {
            bestScore = score;
        }

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

    float BoundHeightCalcaulte(GameObject block)
    {
        float height;
        
        Collider2D newCol = GetComponent<Collider2D>();
        if (newCol == null)
        {
            Bounds totalBounds = new Bounds(block.transform.position, Vector3.zero);
            foreach (var col in block.GetComponentsInChildren<Collider2D>())
            {
                totalBounds.Encapsulate(col.bounds);
            }

            height = totalBounds.max.y;
        }

        else
        {

            height = newCol.bounds.max.y;
        }

        return height;
    }
}
