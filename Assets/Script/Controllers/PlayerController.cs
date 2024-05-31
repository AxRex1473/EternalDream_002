using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 3f;
    public SpriteRenderer spriteRenderer;
    public Animator animator;
    private Rigidbody2D rb;
    public Transform transformPlayer;
    public Transform SpawnPointPlayer;
    public GameObject panelLose;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        panelLose.SetActive(false); // Asegúrate de que el panel esté desactivado al principio
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        if (moveHorizontal < 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (moveHorizontal > 0)
        {
            spriteRenderer.flipX = true;
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fall") || other.CompareTag("Neuron"))
        {
            transformPlayer.position = SpawnPointPlayer.position;
            StartCoroutine(ActivateAndDeactivatePanel());
        }
    }

    IEnumerator ActivateAndDeactivatePanel()
    {
        panelLose.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        panelLose.SetActive(false);
    }
}
