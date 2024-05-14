using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector_1 : MonoBehaviour
{
    public GameObject panelOut; // Referencia al panel que quieres activar

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Comprueba si el collider que ha entrado en contacto tiene el tag "Player_1"
        if (collision.CompareTag("Player_1"))
        {
            // Activa el panel
            panelOut.SetActive(true);
        }
    }
}
