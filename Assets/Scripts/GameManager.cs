using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;

    private UIManager uiManager;
    private bool juegoTerminado = false;
    private void Awake()
    {
        Time.timeScale = 1;
        uiManager = FindObjectOfType<UIManager>();
    }

    private void Update()
    {
       if (!juegoTerminado)
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                timer = 0;
            }

            uiManager.UpdateTimer(timer);

            if (timer <= 0)
            {
                juegoTerminado = true;

                uiManager.MostrarPantallaGameOver();

                Time.timeScale = 0;
            }
        }

        if (juegoTerminado && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void FinalizarJuego()
    {
        juegoTerminado = true;
    }
}
