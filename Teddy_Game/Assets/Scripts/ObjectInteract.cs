using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectInteract : MonoBehaviour
{
    public Inventario inventario;
    public Text puntuacion;

    // Start is called before the first frame update
    void Start()
    {
        
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
        puntuacion.text = " " + inventario;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inventario.Cantidad = inventario.Cantidad + 1;
            puntuacion.text = " " + inventario.Cantidad;
            Destroy(gameObject);
        }
        
    }
}
