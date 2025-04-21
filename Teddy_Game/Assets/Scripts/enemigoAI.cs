using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemigoAI : MonoBehaviour
{
    public Transform Objetivo;
    public float velocidad=0;
    public NavMeshAgent IA;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        IA.speed = velocidad;
        IA.SetDestination(Objetivo.position);

        



    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("attack", true);
        }
        else
        {
            anim.SetBool("attack", false);
        }



        
    }


}