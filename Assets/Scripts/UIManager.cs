using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    public void UpdateScore(int score)
    {
        scoreText.text = "Puntaje: " + score;
    }

    public void UpdateTimer(float timer)
    {
        timerText.text = "Tiempo: " + Mathf.Ceil(timer);
    }
}
