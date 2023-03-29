using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockerPaddleR : MonoBehaviour
{
    private Vector3 originalPos;
    private Vector3 newPos;
    private bool isMoving;
   // Start is called before the first frame update
void Start()
{
    originalPos = transform.position;
}

// Update is called once per frame
void Update()
{
     if (Input.GetKeyDown(KeyCode.D))
    {
        newPos = new Vector3(transform.position.x, transform.position.y + 8, transform.position.z);
        isMoving = true;
    }

    if (Input.GetKeyUp(KeyCode.D))
    {
        newPos = originalPos;
        isMoving = true;
    }

    if (isMoving)
    {
        transform.position = Vector3.MoveTowards(transform.position, newPos, Time.deltaTime * 30);
        if (transform.position == newPos)
        {
            isMoving = false;
        }
    }
}

 private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Mouse" || collision.gameObject.name == "Mouse2")
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                Vector2 direction = (collision.transform.position - transform.position).normalized;
                rb.AddForce(direction * 25, ForceMode2D.Impulse);
                }
            }
    }
}
