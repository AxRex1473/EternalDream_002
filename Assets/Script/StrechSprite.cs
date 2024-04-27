using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrechSprte : MonoBehaviour
{
    private Vector3 initialScale;
    private Vector3 initialMousePosition;

    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            initialMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 currentMousePosition = Input.mousePosition;
            float stretchAmount = (currentMousePosition.x - initialMousePosition.x) * 0.01f;

            // Limitar el estiramiento para que no sea demasiado grande
            stretchAmount = Mathf.Clamp(stretchAmount, -1f, 1f);

            // Estirar el sprite en el eje X
            transform.localScale = new Vector3(initialScale.x + stretchAmount, initialScale.y, initialScale.z);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // Restaurar la escala inicial cuando se suelta el botón del mouse
            transform.localScale = initialScale;
        }
    }
}
