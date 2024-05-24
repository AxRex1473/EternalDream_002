using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public GameObject gameOverPanel; // Referencia al panel de juego terminado
    private float timeRemaining = 120f; // 5 minutes in seconds
    private bool isTimerRunning = true; // Variable para verificar si el temporizador está en funcionamiento

    void Update()
    {
        if (isTimerRunning)
        {
            // Decrease the time remaining
            timeRemaining -= Time.deltaTime;

            // Ensure the timer doesn't go below zero
            if (timeRemaining < 0)
            {
                timeRemaining = 0;
                isTimerRunning = false;
                // Detener el juego y mostrar el panel de juego terminado
                Time.timeScale = 0f; // Pausar el juego
                gameOverPanel.SetActive(true); // Activar el panel de juego terminado
            }

            // Update the timer display
            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        // Convert time remaining to minutes and seconds
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);

        // Update the timer text
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}