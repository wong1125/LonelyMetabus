using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        TowerGameManager.instance.GameOver();
        Destroy(collision.gameObject);
    }
}
