using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterActive : MonoBehaviour
{
    public GameObject Starter;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StarterDesactivate(3f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator StarterDesactivate(float tiempoEspera)
    {
        yield return new WaitForSeconds(tiempoEspera);
        Starter.SetActive(false);
    }
  

}
