using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bglooper : MonoBehaviour
{
    int numBgCount = 4;


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Background"))
        {
            float widthOfBgObject = ((BoxCollider2D)collision).size.x * collision.transform.localScale.x;
            Vector3 pos = collision.transform.position;
            pos.x += widthOfBgObject * numBgCount;
            collision.transform.position = pos;
            return;
        }
        else
        {
            Destroy(collision.gameObject);
        }


    }

}
