using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector_1 : MonoBehaviour
{
    public GameObject victoryPanel; // El panel de victoria que se activar�
    private GameController gameController;

    private void Start()
    {
        gameController = GameController.instance;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player_1"))
        {
            if (gameController.GetPoints() >= gameController.GetTotalPoints())
            {
                victoryPanel.SetActive(true); // Activa el panel de victoria
            }
            else
            {
                Debug.Log("La puerta est� bloqueada. Necesitas recolectar todos los puntos.");
            }
        }
    }
}
