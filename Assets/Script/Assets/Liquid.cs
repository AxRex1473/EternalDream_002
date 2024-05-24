using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liquid : MonoBehaviour
{
    public Sprite nuevoSprite; // El nuevo sprite para cambiar al hacer clic
    private SpriteRenderer spriteRenderer; // El SpriteRenderer del objeto
    private Animator animator; // El Animator del objeto
    private bool playerInRange = false; // Estado de rango del jugador
    public bool isActivate = true;
    public float TimerLiquid = 5;

    public PlayerController player;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Verificar si el jugador está en rango y hace clic con el mouse
        if (playerInRange && Input.GetMouseButtonDown(0))
        {
            // Desactivar el Animator
            animator.enabled = false;

            // Cambiar el sprite manteniendo la configuración de posición y escala
            spriteRenderer.sprite = nuevoSprite;


            isActivate = false;

            
            
        }
        if (isActivate == false)
        {
            TimerLiquid -= Time.deltaTime;
            player.spriteRenderer.color = Color.blue;
            if (TimerLiquid <= 0)
            {
                isActivate = true;
                animator.enabled = true;
                TimerLiquid = 5;
                player.spriteRenderer.color = Color.white;

            }
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
