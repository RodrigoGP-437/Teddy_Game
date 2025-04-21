using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class logicaPersonaje : MonoBehaviour
{
    public estamina eestamina;
    public float velocidadMovimiento = 2.0f;
    public float velocidadCorrer = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y;
    public float SpeedH;
    public float SpeedV;
    float yaw;
    float pitch;
    public Rigidbody rb;
    public float fuerzaDeSalto = 8f;
    public bool puedoSaltar = false;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        eestamina = GameObject.FindWithTag("Player").GetComponent<estamina>();
        //animaciones();
    }

    /*public void animaciones()
    {
        if (Input.GetKeyDown("w"))
        {
            anim.SetBool("caminar", true);
        }
        else
        {
            anim.SetBool("caminar", false);
        }
    }*/



    // Update is called once per frame
    void Update()
    {
        yaw += SpeedH * Input.GetAxis("Mouse X");
        // pitch -= SpeedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        Cursor.visible = false;
        Screen.lockCursor = true;

        if (y > 0f)
        {
            anim.SetBool("caminar", true);
        }
        else
        {
            anim.SetBool("caminar", false);
        }

        if (eestamina.stamina == 0)
        {
            anim.SetBool("correr", false);
            velocidadMovimiento = 2.0f;
        } else if(eestamina.stamina > 0)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("correr", true);
                velocidadMovimiento = velocidadCorrer;
            }
            else
            {
                anim.SetBool("correr", false);
                velocidadMovimiento = velocidadMovimiento;
            }
        }

        

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            velocidadMovimiento = 2.0f;
        }


        if (puedoSaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("saltar", true);
                rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
            }
            else
            {
                anim.SetBool("saltar", false);
            }
            anim.SetBool("tocoSuelo", true);
        }
        else
        {
            EstoyCayendo();
        }
        
           
            
        
    }

    public void EstoyCayendo()
    {
        anim.SetBool("tocoSuelo", false);
        anim.SetBool("saltar", false);
    }
}
