using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeuronY : MonoBehaviour
{
    private bool playerInRange = false;

    public PlayerController player;
    public Transform SpawnPoint;

    private void Update()
    {
        if (playerInRange && player.spriteRenderer.color == Color.white)
        {


        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // Verificar si el jugador entró en el collider
        if (other.CompareTag("Player_1"))
        {
            playerInRange = true;
            if (playerInRange && player.spriteRenderer.color != Color.yellow)
            {
                player.transform.position = SpawnPoint.position;
            }
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