using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject[] paneles; // Array para almacenar los paneles de la historia
    public GameObject Neuron;
    public GameObject Button;
    public GameObject Door;
    public GameObject Adapted;
    public GameObject Exit;

    private int panelActual = 0; // Índice para el panel actual

    private void Start()
    {
        InicializarPaneles();
    }

    // Método para inicializar los paneles (activar el primero y desactivar los demás)
    private void InicializarPaneles()
    {
        for (int i = 0; i < paneles.Length; i++)
        {
            paneles[i].SetActive(i == 0);
        }
        panelActual = 0;
    }

    // Método para avanzar al siguiente panel
    public void SiguientePanel()
    {
        Debug.Log("Avanzando al siguiente panel");
        if (panelActual < paneles.Length - 1)
        {
            paneles[panelActual].SetActive(false); // Desactivar el panel actual
            panelActual++; // Incrementar el índice del panel
            paneles[panelActual].SetActive(true); // Activar el siguiente panel
        }
        else
        {
            // Acción específica para el último panel (panelActual == paneles.Length - 1)
            AccionUltimoPanel();
        }
    }

    // Método para la acción específica en el último panel
    private void AccionUltimoPanel()
    {
        // Desactivar el panel actual
        Debug.Log("Desactivando el último panel");
        paneles[panelActual].SetActive(false);
    }

    // Métodos para manejar otros paneles u objetos (Neuron, Button, Puerta)
    private void TogglePanel(GameObject panel, bool setActive)
    {
        panel.SetActive(setActive);
    }

    public void ToggleNeuronPanel()
    {
        TogglePanel(Neuron, !Neuron.activeSelf);
    }

    public void ToggleButtonPanel()
    {
        TogglePanel(Button, !Button.activeSelf);
    }

    public void TogglePuertaPanel()
    {
        TogglePanel(Door, !Door.activeSelf);
    }

    public void ToggleAdapted()
    {
        TogglePanel(Adapted, !Adapted.activeSelf);
    }

    public void ToggleExit()
    {
        TogglePanel(Exit, !Exit.activeSelf);
    }
}
