using System.Collections;
using System.Collections.Generic;
using Unity.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyMinigameZone : Zone
{

    public void ToFlappyMiniGame()
    {
        SceneManager.LoadScene(1);
    }
}
