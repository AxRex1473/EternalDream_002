using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    private int points = 0;
    private int totalPoints = 1;

    public GameObject door;
    public Sprite unlockedDoorSprite;
    public TextMeshProUGUI pointsText;

    public int level = 1;
    private int level1TotalPoints = 1;
    private int level2TotalPoints = 4;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        SetupLevel();
        UpdatePointsText();
    }

    // Configurar variables según el nivel actual
    void SetupLevel()
    {
        switch (level)
        {
            case 1:
                totalPoints = level1TotalPoints;
                break;
            case 2:
                totalPoints = level2TotalPoints;
                break;
            default:
                totalPoints = level1TotalPoints;
                break;
        }
    }

    public void AddPoint()
    {
        points++;
        int pointsRemaining = totalPoints - points;
        Debug.Log("+1 punto. Faltan " + pointsRemaining + " puntos para desbloquear la puerta.");
        UpdatePointsText();
        CheckPoints();
    }

    void UpdatePointsText()
    {
        if (pointsText != null)
        {
            pointsText.text = "Botones: " + points + "/" + totalPoints;
        }
    }

    public int GetPoints()
    {
        return points;
    }

    public int GetTotalPoints()
    {
        return totalPoints;
    }

    void CheckPoints()
    {
        if (points >= totalPoints)
        {
            UnlockDoor();
        }
    }

    void UnlockDoor()
    {
        Debug.Log("¡Puerta desbloqueada! Has recolectado todos los puntos.");
        SpriteRenderer doorSpriteRenderer = door.GetComponent<SpriteRenderer>();
        if (doorSpriteRenderer != null && unlockedDoorSprite != null)
        {
            doorSpriteRenderer.sprite = unlockedDoorSprite;
        }
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
