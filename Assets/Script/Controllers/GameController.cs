using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    private int points = 0;
    private int totalPoints = 1; // Total de objetos a recolectar

    public GameObject door; // La puerta que se desbloquea
    public Sprite unlockedDoorSprite; // El nuevo sprite para la puerta desbloqueada
    public TextMeshProUGUI pointsText; // Referencia al TextMeshPro para mostrar los puntos

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
        UpdatePointsText(); // Actualizar el texto al inicio
    }

    public void AddPoint()
    {
        points++;
        int pointsRemaining = totalPoints - points;
        Debug.Log("+1 punto. Faltan " + pointsRemaining + " puntos para desbloquear la puerta.");
        UpdatePointsText(); // Actualizar el texto cada vez que se agrega un punto
        CheckPoints();
    }

    void UpdatePointsText()
    {
        if (pointsText != null)
        {
            pointsText.text = "Baterias: " + points + "/" + totalPoints;
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
            doorSpriteRenderer.sprite = unlockedDoorSprite; // Cambia el sprite de la puerta
        }
    }
}
