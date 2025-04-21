using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class empezarJuego : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    public void cambiarEscena()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            cambiarEscena();
        }
    }
}
