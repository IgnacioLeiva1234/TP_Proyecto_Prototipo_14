using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public GameObject WinPanel;
    public GameObject DefeatPanel;

    public void UpdateScore(int score)
    {
        scoreText.text = "Puntaje: " + score;
    }

    public void UpdateTimer(float timer)
    {
        timerText.text = "Tiempo: " + Mathf.Ceil(timer);
    }
     public void MostrarPantallaWin()
    {
        WinPanel.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        DefeatPanel.SetActive(true);
    }
}
