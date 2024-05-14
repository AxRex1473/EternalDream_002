using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
   
    public GameObject message1;
    //public GameObject room1;
    //public GameObject room2;
    //public GameObject room3;


    private void Start()
    {
        //TogglePanel(room1, false); // Desactivar las rooms al iniciar el juego
        //TogglePanel(room2, false); //
        //TogglePanel(room3, false); // 
        Debug.Log("Desactivado Room");
    }

   

    private void TogglePanel(GameObject panel, bool setActive)
    {
        panel.SetActive(setActive); // Activa o desactiva el panel según el parámetro setActive
    }

    public void ToggleMessagePanel()
    {
        TogglePanel(message1, !message1.activeSelf);
    }
    //public void ToggleRoom1Panel()
    //{
    //    TogglePanel(room1, !room1.activeSelf);// Activa o desactiva el panel de mensaje según su estado actual

    //}
    //public void ToggleRoom2Panel()
    //{
    //    TogglePanel(room2, !room2.activeSelf);// Activa o desactiva el panel de mensaje según su estado actual
    //}
    //public void ToggleRoom3Panel()
    //{
    //    TogglePanel(room3, !room3.activeSelf);// Activa o desactiva el panel de mensaje según su estado actual
    //}

}
