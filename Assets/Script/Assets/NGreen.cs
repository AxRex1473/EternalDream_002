using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NGreen : MonoBehaviour
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
        if (other.CompareTag("Player_1"))
        {
            playerInRange = true;
            if (playerInRange && player.spriteRenderer.color != Color.green)
            {
                player.transform.position = SpawnPoint.position;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player_1"))
        {
            playerInRange = false;
        }
    }
}
