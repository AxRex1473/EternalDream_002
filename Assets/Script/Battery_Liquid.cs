using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery_Liquid : MonoBehaviour
{
    public Sprite nuevoSprite;

    private SpriteRenderer spriteRenderer;
    private Animator animator;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (spriteRenderer != null && nuevoSprite != null)
        {
            animator.enabled = false;
            spriteRenderer.sprite = nuevoSprite;
        }
    }
}