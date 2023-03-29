using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] UIManager uIManager;
    [SerializeField] int score = 0;
    public void AddCounter(int amount)
    {
        score += amount;
        uIManager.SetScoreText(score);
    }

    
}