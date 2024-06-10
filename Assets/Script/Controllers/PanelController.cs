using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject[] paneles; 
    public GameObject Neuron;
    public GameObject Button;
    public GameObject Door;
    public GameObject Adapted;
    public GameObject Exit;
    public GameObject MsgN2;

    private int panelActual = 0; 

    private void Start()
    {
        InicializarPaneles();
    }

    private void InicializarPaneles()
    {
        for (int i = 0; i < paneles.Length; i++)
        {
            paneles[i].SetActive(i == 0);
        }
        panelActual = 0;
    }

    public void SiguientePanel()
    {
        Debug.Log("Avanzando al siguiente panel");
        if (panelActual < paneles.Length - 1)
        {
            paneles[panelActual].SetActive(false); 
            panelActual++; 
            paneles[panelActual].SetActive(true); 
        }
        else
        {
            AccionUltimoPanel();
        }
    }

    private void AccionUltimoPanel()
    {
        // Desactivar el panel actual
        Debug.Log("Desactivando el último panel");
        paneles[panelActual].SetActive(false);
    }

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

    public void ToggleMsg2()
    {
        TogglePanel(MsgN2, !MsgN2.activeSelf);
    }
}
