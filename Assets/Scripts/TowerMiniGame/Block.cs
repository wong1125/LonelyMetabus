using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    bool isLanded = false;
    Rigidbody2D rb;

    TowerGameManager tGM;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tGM = TowerGameManager.instance;
    }

    public void Drop()
    {
        rb.gravityScale = 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isLanded)
            return;
        else
        {
            isLanded = true;
            tGM.SetHighestBlock(this.gameObject);
            BlockSpawnController.instance.NextBlock();
        }

    }
}
