using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vidaPlayer : MonoBehaviour
{
    public float vida = 100;

    public Image barraDeVida;

    public void morir()
    {
        
            Debug.Log("Perdiste");
            SceneManager.LoadScene("menu");
        Cursor.lockState = CursorLockMode.None;

    }

    // Update is called once per frame
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);

        barraDeVida.fillAmount = vida / 100;
    if (vida == 0)
    {
            morir();
    }
    }
}
