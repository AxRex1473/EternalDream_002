using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timeRemaining = 300f; // 5 minutes in seconds

    void Update()
    {
        // Decrease the time remaining
        timeRemaining -= Time.deltaTime;

        // Ensure the timer doesn't go below zero
        if (timeRemaining < 0)
        {
            timeRemaining = 0;
            // You can perform any action here when the timer reaches 0
        }

        // Update the timer display
        UpdateTimerDisplay();
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