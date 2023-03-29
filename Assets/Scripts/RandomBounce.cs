using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBounce : MonoBehaviour
{
    public CircleCollider2D circleCollider;
    public float minBounciness = 0.5f;
    public float maxBounciness = 1.0f;
    

    private void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
    }

    private void Update()
    {
        float bounciness2 = Random.Range(minBounciness, maxBounciness);
        circleCollider.sharedMaterial.bounciness = bounciness2;
        
    }
}
