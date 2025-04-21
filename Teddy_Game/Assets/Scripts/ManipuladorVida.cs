using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ManipuladorVida : MonoBehaviour
{

    vidaPlayer playerVida;

    public int cantidad;
    public float damageTime;
    float currentDamageTime;
    public AudioSource emisor;
    public AudioClip sonidito;
    public float volumen = 1;

    // Start is called before the first frame update
    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<vidaPlayer>();
    }

    public void morir()
    {

        Debug.Log("Perdiste");
        SceneManager.LoadScene("menu");
        Cursor.lockState = CursorLockMode.None;

    }



    private void OnTriggerStay(Collider other)
    {
        if (playerVida.vida == 0)
        {
            morir();
        }
        if (other.tag == "Player")
        {
            emisor.Play();
            currentDamageTime += Time.deltaTime;
            if (currentDamageTime > damageTime)
            {
                playerVida.vida += cantidad;
                currentDamageTime = 0.0f;

            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {

            emisor.Play();
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}