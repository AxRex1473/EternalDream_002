using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public GameObject gameOverPanel;
    public Button startButton; 

    public float timeRemaining;
    private bool isTimerRunning = false;

    public int level = 1;
    private float level1Time = 120;
    private float level2Time = 180;

    void Start()
    {
        startButton.onClick.AddListener(StartTimer);
        gameOverPanel.SetActive(false);
        SetupLevel();
        UpdateTimerDisplay();
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (isTimerRunning)
        {
            timeRemaining -= Time.deltaTime;

            if (timeRemaining < 0)
            {
                timeRemaining = 0;
                isTimerRunning = false;
                Time.timeScale = 0f;
                gameOverPanel.SetActive(true);
            }

            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void StartTimer()
    {
        isTimerRunning = true;
        startButton.gameObject.SetActive(false); 
    }

    void SetupLevel()
    {
        switch (level) 
        {
            case 1:
                timeRemaining = level1Time;
                break;
            case 2:
                timeRemaining = level2Time; 
                break;
            default:
                timeRemaining = level1Time;
                break;
        }
    }
}
