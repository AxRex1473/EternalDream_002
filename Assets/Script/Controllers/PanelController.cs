using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
   
    public GameObject message1;
    public GameObject message2;
    public GameObject message3;
    public GameObject message4;

    private void Start()
    {
    }

    private void TogglePanel(GameObject panel, bool setActive)
    {
        panel.SetActive(setActive); 
    }

    public void ToggleMessagePanel()
    {
        TogglePanel(message1, !message1.activeSelf);
    }

    private void TogglePanel1(GameObject panel, bool setActive)
    {
        panel.SetActive(setActive);
    }

    public void ToggleMessagePanel1()
    {
        TogglePanel1(message2, !message2.activeSelf);
    }

    private void TogglePanel2(GameObject panel, bool setActive)
    {
        panel.SetActive(setActive);
    }

    public void ToggleMessagePanel2()
    {
        TogglePanel2(message3, !message3.activeSelf);
    }

    private void TogglePanel3(GameObject panel, bool setActive)
    {
        panel.SetActive(setActive);
    }

    public void ToggleMessagePanel3()
    {
        TogglePanel3(message4, !message4.activeSelf);
    }
}
