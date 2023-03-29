using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject mousePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnNewMouse();
        }
    }
    void SpawnNewMouse()
    {
        Vector2 pos = new Vector2(Random.Range(-0.5f, 0.5f), 6);
        Instantiate(mousePrefab, pos, Quaternion.identity);
    }
}
