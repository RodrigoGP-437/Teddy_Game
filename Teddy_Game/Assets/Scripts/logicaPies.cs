using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaPies : MonoBehaviour
{
    public logicaPersonaje loogicaPersonaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        loogicaPersonaje.puedoSaltar = true;
    }

    private void OnTriggerExit(Collider other)
    {
        loogicaPersonaje.puedoSaltar = false;
    }
}
