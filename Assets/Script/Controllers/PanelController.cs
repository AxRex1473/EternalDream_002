using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject[] paneles; // Array para almacenar los paneles de la historia
    public GameObject Neuron;
    public GameObject Button;
    public GameObject Door;
    public GameObject Adapted;
    public GameObject Exit;

    private int panelActual = 0; // �ndice para el panel actual

    private void Start()
    {
        InicializarPaneles();
    }

    // M�todo para inicializar los paneles (activar el primero y desactivar los dem�s)
    private void InicializarPaneles()
    {
        for (int i = 0; i < paneles.Length; i++)
        {
            paneles[i].SetActive(i == 0);
        }
        panelActual = 0;
    }

    // M�todo para avanzar al siguiente panel
    public void SiguientePanel()
    {
        Debug.Log("Avanzando al siguiente panel");
        if (panelActual < paneles.Length - 1)
        {
            paneles[panelActual].SetActive(false); // Desactivar el panel actual
            panelActual++; // Incrementar el �ndice del panel
            paneles[panelActual].SetActive(true); // Activar el siguiente panel
        }
        else
        {
            // Acci�n espec�fica para el �ltimo panel (panelActual == paneles.Length - 1)
            AccionUltimoPanel();
        }
    }

    // M�todo para la acci�n espec�fica en el �ltimo panel
    private void AccionUltimoPanel()
    {
        // Desactivar el panel actual
        Debug.Log("Desactivando el �ltimo panel");
        paneles[panelActual].SetActive(false);
    }

    // M�todos para manejar otros paneles u objetos (Neuron, Button, Puerta)
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
