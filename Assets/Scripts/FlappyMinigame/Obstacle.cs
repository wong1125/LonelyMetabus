using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    int numBgCount = 4;

    private void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision");

        if (collision.CompareTag("Background"))
        {

            Debug.Log("Triggerd");
            float widthOfBgObject = ((BoxCollider2D)collision).size.x;
            Vector3 pos = collision.transform.position;

            pos.x += widthOfBgObject * numBgCount;
            collision.transform.position = pos;
            return;
        }

        
    }

}
