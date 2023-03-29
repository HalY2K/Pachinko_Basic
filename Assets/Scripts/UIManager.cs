using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text displayText;
    public void SetScoreText(int score)
    {
        displayText.text = "Score: " + score;
    }
}
