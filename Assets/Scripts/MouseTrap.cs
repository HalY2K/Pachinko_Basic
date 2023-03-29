using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTrap : MonoBehaviour
{
    [SerializeField] GameController gameController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Mouse mouse = collision.gameObject.GetComponent<Mouse>();
        if (mouse)
        {
            Destroy(mouse.gameObject);
            gameController.AddCounter(1);
        }
    }
}
