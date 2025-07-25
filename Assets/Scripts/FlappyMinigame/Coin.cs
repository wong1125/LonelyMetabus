using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float randomYpos;

    // Start is called before the first frame update
    void Start()
    {
        randomYpos = Random.Range(-2.8f, 2.8f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
