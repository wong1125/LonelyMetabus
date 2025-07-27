using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeaderBoardZone : Zone
{
    public TextMeshProUGUI flappyBestScore;

    public TextMeshProUGUI TowerBestScore;

    private void Start()
    {
        if (PlayerPrefs.HasKey("FlappyBestScore"))
            flappyBestScore.text = PlayerPrefs.GetInt("FlappyBestScore").ToString();
        if (PlayerPrefs.HasKey("TowerBestScore"))
            TowerBestScore.text = PlayerPrefs.GetFloat("TowerBestScore").ToString("N1");
    }
}
