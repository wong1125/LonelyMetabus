using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamerController : MonoBehaviour
{
    [SerializeField] float flapPower = 15.0f;
    [SerializeField] float fowardSpeed = 5.0f;
    bool isFlap = false;
    bool isDie = false;
    FlappyGameManager fGM;
    public bool IsDie {  get { return isDie; } }

    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void Start()
    {
        fGM = FlappyGameManager.instance;
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
        if (isDie)
            return;       
        Vector3 velocity = rb.velocity;
        velocity.x = fowardSpeed;
        rb.velocity = velocity;
        Vector2 antiGravity = new Vector2(0, flapPower);
        if (isFlap)
        {
            rb.AddForce(antiGravity);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Coin"))
        {
            Debug.Log("Triggered");
            FlappyGameManager.instance.AddScore();
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Obstacle"))
        {
            isDie = true;
            fGM.GameEnd();
        }
    }


}
