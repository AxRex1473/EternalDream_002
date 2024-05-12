using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject message1;
    public GameObject room1;
    private bool playerEntered;

    private void Start()
    {
        TogglePanel(room1, false); // Desactivar room1 al iniciar el juego
        Debug.Log("Desactivado Room");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !playerEntered)
        {
            playerEntered = true;
            TogglePanel(room1, true);
            Debug.Log("Player entered collider");
        }
    }

    private void TogglePanel(GameObject panel, bool setActive)
    {
        panel.SetActive(setActive); // Activa o desactiva el panel según el parámetro setActive
    }

    public void ToggleMessagePanel()
    {
        TogglePanel(message1, !message1.activeSelf); // Activa o desactiva el panel de mensaje según su estado actual
    }
}
