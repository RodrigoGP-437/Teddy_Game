using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public int Cantidad = 0;
    public Text mensaje;

    void Update()
    {
        cambiarObj();
    }

    public void cambiarObj()
    {
        if (Cantidad >= 10)
            mensaje.text = "Objetivo: Busca la cueva y entrega la miel.";
    }
}
