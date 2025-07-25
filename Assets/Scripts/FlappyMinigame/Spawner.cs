using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coin;
    public GameObject obstacle;
    public MiniGamerController miniGamer;

    float coinInterval = 5;
    float obstacleInterval = 3;

    
    void Start()
    {
        StartCoroutine(ObjSpawner(coin, coinInterval));
        StartCoroutine(ObjSpawner(obstacle, obstacleInterval));
    }


    private IEnumerator ObjSpawner(GameObject obj, float interval)
    {

        while (!miniGamer.IsDie)
        {
            float randomziedPosNum = Random.Range(-2.8f, 2.8f);

            Vector2 spawnPos = new Vector2(miniGamer.transform.position.x + 20, randomziedPosNum);


            Instantiate(obj, spawnPos, Quaternion.identity);
            
            yield return new WaitForSeconds(interval);
        }

    }

}
