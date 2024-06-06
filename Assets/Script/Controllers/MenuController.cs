using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public int sceneIndex; // Asegúrate de que esté correctamente escrito
    public float delay = 2.0f;
    public GameObject panelSettings;
    public GameObject panelMenu;

    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenSettings()
    {
        panelSettings.SetActive(true);
        panelMenu.SetActive(false);
    }

    public void CloseSettings()
    {
        panelSettings.SetActive(false);
        panelMenu.SetActive(true);
    }
}
