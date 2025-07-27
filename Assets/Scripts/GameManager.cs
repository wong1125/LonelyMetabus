using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject player;

    private bool isUIOpen = false;
    public bool IsUIOpen { get { return isUIOpen; } }

    private bool onBoat;
    public bool OnBoat {  get { return onBoat; } }

    private bool lifeVest = false;
    public bool LifeVest {  get { return lifeVest; } }

    private bool goodSwim = false;
    public bool GoodSwim { get { return goodSwim; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void SetUIOpen()
    {
        isUIOpen = !isUIOpen;
    }

    public void SetOnBoat()
    {
        onBoat = !onBoat;
    }

    public void SetLifeVest()
    {
        lifeVest = !lifeVest;
    }

    public void SetGoodSwim()
    {
        int score = 0;
        if (PlayerPrefs.HasKey("FlappyBestScore"))
            score = PlayerPrefs.GetInt("FlappyBestScore");
        if (score >= 5)
            goodSwim = true;
    }
}
