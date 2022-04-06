using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanterna : MonoBehaviour
{

    public GameObject Lanterna;

    public AudioSource ligar;
    public AudioSource desligar;

    public bool ligado;
    public bool desligado;

    // Start is called before the first frame update
    void Start()
    {
        desligado = true;
        Lanterna.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (desligado && Input.GetButtonDown("Lanterna"))
        {
            Lanterna.SetActive(true);
            ligar.Play();
            desligado = false;
            ligado = true;
        }
        else if (ligado && Input.GetButtonDown("Lanterna"))
        {
            Lanterna.SetActive(false);
            desligar.Play();
            desligado = true;
            ligado = false;
        }
    }
}
