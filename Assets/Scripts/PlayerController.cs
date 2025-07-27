using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float movingSpeed = 5.0f;
    float speedMemory;
    GameManager gM;
    
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        gM = GameManager.instance;
        speedMemory = movingSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gM.IsUIOpen)
            movingSpeed = 0;
        else
            movingSpeed = speedMemory;

        ArrowMove();
    }

    void ArrowMove()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector2 movingVector = new Vector2(horizontal, vertical) * movingSpeed;
        rb.velocity = movingVector;
    }


}
