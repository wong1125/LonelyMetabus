using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamerController : MonoBehaviour
{
    [SerializeField] float flapPower = 15.0f;
    [SerializeField] float fowardSpeed = 5.0f;
    bool isFlap = false;

    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            isFlap = true;
        }
        else
        {
            isFlap = false;
        }
    }

    void FixedUpdate()
    {
        Vector3 velocity = rb.velocity;
        velocity.x = fowardSpeed;
        rb.velocity = velocity;
        Vector2 antiGravity = new Vector2(0, flapPower);
        if (isFlap)
        {
            rb.AddForce(antiGravity);
        }


    }

  
}
