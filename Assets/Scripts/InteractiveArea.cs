using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    public int score = 0;

    public int maxScore = 3;

    private UIManager uiManager;
    private GameManager gameManager;

    private void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            score++;

            uiManager.UpdateScore(score);

            Destroy(other.gameObject);

            if (score >= maxScore)
            {
                uiManager.MostrarPantallaWin();

                gameManager.FinalizarJuego();

                Time.timeScale = 0;
            }
        }
    }
}
