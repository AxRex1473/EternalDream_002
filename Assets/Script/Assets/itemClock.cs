using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemClock : MonoBehaviour
{
    private bool isCollected = false;
    private bool playerInRange = false;
    public CountdownTimer timer;

    private void Update()
    {
        // Verificar si el jugador está en rango y hace clic con el mouse
        if (playerInRange && Input.GetMouseButtonDown(0) && !isCollected)
        {
            timer.timeRemaining = timer.timeRemaining + 30;
            isCollected = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el jugador entró en el collider
        if (other.CompareTag("Player_1"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Verificar si el jugador salió del collider
        if (other.CompareTag("Player_1"))
        {
            playerInRange = false;
        }
    }
}
