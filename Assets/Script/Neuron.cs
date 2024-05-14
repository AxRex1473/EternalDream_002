using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neuron : MonoBehaviour
{
    public Sprite neuronaFria;
    private SpriteRenderer spriteRenderer;
    private bool isCollected = false;
    private bool playerInRange = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Verificar si el jugador está en rango y hace clic con el mouse
        if (playerInRange && Input.GetMouseButtonDown(0) && !isCollected)
        {
            spriteRenderer.sprite = neuronaFria;
            isCollected = true; // Marcar como recogido
            GameController.instance.AddPoint(); // Agregar un punto
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