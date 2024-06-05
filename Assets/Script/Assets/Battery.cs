using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{ 
    public Sprite nuevoSprite; // El nuevo sprite para cambiar al hacer clic
    private SpriteRenderer spriteRenderer; // El SpriteRenderer del objeto
    private bool isCollected = false; // Estado de recolecci�n
    private bool playerInRange = false; // Estado de rango del jugador
    public BoxCollider2D puerta;
    public SpriteRenderer sprPuerta;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Verificar si el jugador est� en rango y hace clic con el mouse
        if (playerInRange && Input.GetMouseButtonDown(0) && !isCollected)
        {
            // Cambiar el sprite manteniendo la configuraci�n de posici�n y escala
            spriteRenderer.sprite = nuevoSprite;

            // Marcar el objeto como recogido
            isCollected = true;

            // Agregar un punto al contador en el GameController
            GameController.instance.AddPoint();
            puerta.isTrigger = true;
            Destroy(sprPuerta);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el jugador entr� en el collider
        if (other.CompareTag("Player_1"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Verificar si el jugador sali� del collider
        if (other.CompareTag("Player_1"))
        {
            playerInRange = false;
        }
    }
}