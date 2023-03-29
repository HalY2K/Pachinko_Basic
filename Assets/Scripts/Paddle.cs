using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed;
    [SerializeField] KeyCode moveKey;
    [SerializeField] float topBound;
    [SerializeField] float bottomBound;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(moveKey) && transform.position.y < topBound)
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed);
            return;
        }

        if (Input.GetKey(moveKey))
        {
            return;
        }

        if (transform.position.y >bottomBound)
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed);
        }
        else
        {
            Vector2 pos = transform.position;
            pos.y = bottomBound;
            transform.position = pos;
        }
    }
}
