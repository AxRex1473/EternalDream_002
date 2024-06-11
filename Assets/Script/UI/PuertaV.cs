using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaV : MonoBehaviour
{
    private bool playerInRange = false;
    public GameObject puertaV;
    private bool panelActivated = false; // Flag to check if the panel has already been activated

    private void Start()
    {
        puertaV.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player_1") && !panelActivated)
        {
            playerInRange = true;
            puertaV.SetActive(true);
            panelActivated = true; // Set the flag to true after activating the panel
        }
    }
}
