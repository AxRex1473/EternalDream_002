using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puerta : MonoBehaviour
{
    public GameObject victoryPanel; // El panel de victoria que se activará
    private GameController gameController;
    public int sceneIndex; // Asegúrate de que esté correctamente escrito
    public float delay = 2.0f;

    private void Start()
    {
        gameController = GameController.instance;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player_1"))
        {
            if (gameController.GetPoints() >= gameController.GetTotalPoints())
            {
                victoryPanel.SetActive(true); // Activa el panel de victoria
                Time.timeScale = 0; // Detiene el juego
                StartCoroutine(ChangeSceneAfterDelay()); // Inicia la corrutina para cambiar de escena con delay
            }
            else
            {
                Debug.Log("La puerta está bloqueada. Necesitas recolectar todos los puntos.");
            }
        }
    }

    private IEnumerator ChangeSceneAfterDelay()
    {
        yield return new WaitForSecondsRealtime(delay); // Espera el tiempo de delay en tiempo real
        Time.timeScale = 1; // Restaura el tiempo de juego
        SceneManager.LoadScene(sceneIndex);
    }
}
