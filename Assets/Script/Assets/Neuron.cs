using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neuron : MonoBehaviour
{
    public Sprite neuronaFria;
    private SpriteRenderer spriteRenderer;
    private bool playerInRange = false;

    public PlayerController player;
    public Transform SpawnPoint;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Verificar si el jugador está en rango y hace clic con el mouse
        if (playerInRange && player.spriteRenderer.color == Color.blue)
        {
           
            spriteRenderer.sprite = neuronaFria;
        }
       
            
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // Verificar si el jugador entró en el collider
        if (other.CompareTag("Player_1"))
        {
            playerInRange = true;
            if (playerInRange && player.spriteRenderer.color != Color.blue)
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