using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class estamina : MonoBehaviour
{
    public float cantidad;
    public float stamina = 100;
    public float VelocidadDeCorrer;
    public float StaminaRestante;
    public Image barraDeStamina;
    public GameObject player;
    void Start ()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        stamina = Mathf.Clamp(stamina, 0, 100);

        barraDeStamina.fillAmount = stamina / 100;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            stamina -= cantidad;
        }

        if (Input.GetKey(KeyCode.LeftShift) == false)
        {
            stamina += cantidad;
        }

    }
}