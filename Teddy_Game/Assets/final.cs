using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class final : MonoBehaviour
{
    public GameObject detect;
    // Start is called before the first frame update
    void Start()
    {
        detect.SetActive(false);        
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            detect.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                SceneManager.LoadScene("menu");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
