using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    private bool playerInRange = false;
    public GameObject exitPanel;
    public GameObject exitPanel2;

    private void Start()
    {
        exitPanel.SetActive(false);
        exitPanel2.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player_1"))
        {
            playerInRange = true;
            exitPanel.SetActive(true);
        }
        if (other.CompareTag("Player_1"))
        {
            playerInRange = true;
            exitPanel2.SetActive(true);
        }
    }
}
