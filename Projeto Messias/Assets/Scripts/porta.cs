using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porta : MonoBehaviour
{

    public Animator port;
    public GameObject abrirTxt;

    public AudioSource somDaPorta;

    public bool noAlcance;


    void Start()
    {
        noAlcance = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "reach")
        {
            noAlcance = true;
            abrirTxt.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "reach")
        {
            noAlcance = false;
            abrirTxt.SetActive(false);
        }
    }

    void Update()
    {
        if (noAlcance && Input.GetButtonDown("Interagir"))
        {
            AbrePort();
        }

        else
        {
            FechaPort();
        }
        
    }

    void AbrePort()
    {    
        port.SetBool("Abrir", true);
        port.SetBool("Fechar", false);
        somDaPorta.Play();
    }

    void FechaPort()
    {   
        port.SetBool("Abrir", false);
        port.SetBool("Fechar", true);
    }
}
