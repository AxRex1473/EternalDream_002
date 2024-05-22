using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lr_Testing : MonoBehaviour
{
    [SerializeField] Transform[] points;
    [SerializeField] LineController lineController;

    private void Start()
    {
        lineController.SetUpLine(points);
    }
}