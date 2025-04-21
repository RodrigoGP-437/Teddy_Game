using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cambiarTexto : MonoBehaviour
{

    public Text mensaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if( other.tag == "Player")
        mensaje.text = "Objetivo: Huye";
        mensaje.color = new Color(1, 0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
