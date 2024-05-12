using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neuron : MonoBehaviour
{
    public Sprite neuronaFria;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (spriteRenderer != null && neuronaFria != null)
        {
            spriteRenderer.sprite = neuronaFria;
        }
    }
}