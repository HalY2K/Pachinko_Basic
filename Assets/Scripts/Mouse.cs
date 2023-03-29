using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float paddleForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Paddle paddle = collision.gameObject.GetComponent<Paddle>();
        if(paddle)
        {
            Vector2 dir = (collision.contacts[0].point - (Vector2)transform.position).normalized;
            rb.AddForce(dir*paddleForce,ForceMode2D.Impulse);
        }
    }
}
