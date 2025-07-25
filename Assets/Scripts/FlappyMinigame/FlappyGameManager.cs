using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyGameManager : MonoBehaviour
{
    public static FlappyGameManager instance;

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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score++;
        if (score >= bestScore)
        {
            bestScore = Score;
        }
        Debug.Log(score);
    }
}
