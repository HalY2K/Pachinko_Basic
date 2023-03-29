using UnityEngine;

public class MovementController : MonoBehaviour
{
    //public float moveSpeed = 5f; // The speed to move the GameObjects at

    [SerializeField] GameObject LeftPaddle; // The GameObject to move with the A key
    [SerializeField] GameObject RightPaddle; // The GameObject to move with the D key

    Vector3 originalPosL;
    private Vector3 originalPosR;
    private Vector3 newPosL;
    private Vector3 newPosR;
    private bool isMoving;

    private void Awake()
    {
        LeftPaddle = GameObject.Find("LeftPaddle");
        RightPaddle = GameObject.Find("RightPaddle");
    }
    private void Start()
    {
        originalPosL = LeftPaddle.transform.position;
        originalPosR = RightPaddle.transform.position;
     
    }

    private void Update()
    {
        // Move the LeftPaddle GameObject when the A key is pressed
        if (Input.GetKey(KeyCode.A))
        {
            newPosL = new Vector3(LeftPaddle.transform.position.x, LeftPaddle.transform.position.y + 8);
            isMoving = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            newPosL = originalPosL;
            isMoving = true;
        }
        // Move the RightPaddle GameObject when the D key is pressed
        if (Input.GetKey(KeyCode.D))
        {
            newPosR = new Vector3(RightPaddle.transform.position.x, RightPaddle.transform.position.y + 8);
            isMoving = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            newPosR = originalPosR;
            isMoving = true;
        }
        if (isMoving && Input.GetKeyUp(KeyCode.A))
        {
            transform.position = Vector3.MoveTowards(LeftPaddle.transform.position, newPosL, Time.deltaTime * 30);
            if (transform.position == newPosL)
            {
                isMoving = false;
            }

        }
        if (isMoving && Input.GetKeyUp(KeyCode.D))
        {
            transform.position = Vector3.MoveTowards(RightPaddle.transform.position, newPosR, Time.deltaTime * 30);
            if (transform.position == newPosR)
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
                Vector3 direction = (collision.transform.position - transform.position).normalized;
                rb.AddForce(direction * 25, ForceMode2D.Impulse);
            }
        }
    }
}