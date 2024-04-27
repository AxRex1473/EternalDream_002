using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del personaje
    private SpriteRenderer spriteRenderer; // Referencia al componente SpriteRenderer
    private Animator animator;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Obtener el componente SpriteRenderer del personaje
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Obtener la entrada del teclado
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calcular el vector de movimiento
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);

        // Aplicar el movimiento al personaje
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Flip del personaje en función de la dirección horizontal
        if (moveHorizontal < 0)
        {
            spriteRenderer.flipX = true; // Girar el sprite hacia la izquierda
        }
        else if (moveHorizontal > 0)
        {
            spriteRenderer.flipX = false; // Girar el sprite hacia la derecha
        }

        if (moveHorizontal != 0 || moveVertical != 0)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
