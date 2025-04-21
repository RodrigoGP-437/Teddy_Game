using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class sonido : MonoBehaviour
{

    public AudioSource emisor;
    public AudioClip sonidito;
    public float volumen = 1;
    
    private void OnTriggerEnter(Collider other)
    {
        emisor.PlayOneShot(sonidito,volumen);
    }


}
