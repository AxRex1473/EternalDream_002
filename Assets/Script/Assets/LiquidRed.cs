using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LiquidRed : MonoBehaviour
{
    public Sprite nuevoSprite;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private bool playerInRange = false;
    public bool isActivate = true;
    public float TimerLiquid = 5;
    public GameObject click;

    public PlayerController player;
    public TextMeshProUGUI timerColor;

    public int level = 1;
    private float level1TimerLiquid = 5;
    private float level2TimerLiquid = 10;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        SetupLevel();

        if (timerColor != null)
        {
            timerColor.text = "Color: " + TimerLiquid.ToString("F2");
        }
    }

    private void Update()
    {
        if (level != 2) // Solo activa/desactiva click si no es el nivel 2
        {
            if (playerInRange)
            {
                click.SetActive(true);
            }
            else
            {
                click.SetActive(false);
            }
        }

        if (playerInRange && Input.GetMouseButtonDown(0))
        {
            animator.enabled = false;
            spriteRenderer.sprite = nuevoSprite;
            isActivate = false;
        }

        if (isActivate == false)
        {
            TimerLiquid -= Time.deltaTime;
            player.spriteRenderer.color = Color.red;

            if (timerColor != null)
            {
                timerColor.text = "Timer: " + TimerLiquid.ToString("F2");
            }

            if (TimerLiquid <= 0)
            {
                isActivate = true;
                animator.enabled = true;
                ResetTimer();
                player.spriteRenderer.color = Color.white;

                if (timerColor != null)
                {
                    timerColor.text = "Timer: " + TimerLiquid.ToString("F2");
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player_1"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player_1"))
        {
            playerInRange = false;
        }
    }

    // Configurar variables según el nivel actual
    void SetupLevel()
    {
        switch (level)
        {
            case 1:
                TimerLiquid = level1TimerLiquid;
                break;
            case 2:
                TimerLiquid = level2TimerLiquid;
                click.SetActive(false);
                break;
            default:
                TimerLiquid = level1TimerLiquid;
                break;
        }
    }

    // Restablecer el temporizador según el nivel actual
    void ResetTimer()
    {
        switch (level)
        {
            case 1:
                TimerLiquid = level1TimerLiquid;
                break;
            case 2:
                TimerLiquid = level2TimerLiquid;
                click.SetActive(false);
                break;
            default:
                TimerLiquid = level1TimerLiquid;
                break;
        }
    }
}
