
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseStartPos : MonoBehaviour
{
    bool gameStarted = false;
    //public GameObject mousePrefab;
    //public GameObject mousePrefab2;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !gameStarted)
        {
            gameStarted = true;
            //SpawnMice();
            float locX = UnityEngine.Random.Range(-.5f, .5f);
            transform.position = new Vector2(locX, 6);//put back to 6

        }
       
    }
 
}

//void SpawnMice()
//{
//    float locX = Random.Range(-0.5f, 0.5f);
//    GameObject mouse = Instantiate(mousePrefab, new Vector2(locX, 6), Quaternion.identity);
//    //mouse.name = "Mouse";
//    mouse.transform.localScale = new Vector2(0.3f, 0.3f);
//    GameObject mouse2 = Instantiate(mousePrefab, new Vector2(locX, 6), Quaternion.identity);
//    //mouse2.name = "Mouse2";
//    mouse2.transform.localScale = new Vector2(0.3f, 0.3f);
//}

//public class MouseStartPos : MonoBehaviour
//{
//    bool gameStarted = false;
//    public GameObject mousePrefab;
//    public GameObject mousePrefab2;
//    public GameObject CubeCounter
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.Space) && !gameStarted)
//        {
//            gameStarted = true;
//            //SpawnMice();
//            float locX = Random.Range(-.5f, .5f);
//            transform.position = new Vector2(locX, 6);

//        }

//    }
//}