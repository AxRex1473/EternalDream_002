using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3f; // Velocidad de movimiento del personaje
    public float jumpForce = 10f; // Fuerza de salto del personaje
    private SpriteRenderer spriteRenderer; // Referencia al componente SpriteRenderer
    private Animator animator;
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Obtener el componente SpriteRenderer del personaje
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
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
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.y, jumpForce);
        }
    }
}
