using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetosDaño : MonoBehaviour
{
    vidaPlayer playerVida;

    public int cantidad;
    public float damageTime;
    float currentDamageTime;

    // Start is called before the first frame update
    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<vidaPlayer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            
                playerVida.vida += cantidad;
           

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
