using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TowerMinigameZone : Zone
{
    public void ToTowerMiniGame()
    {
        SceneManager.LoadScene(2);
    }
}
