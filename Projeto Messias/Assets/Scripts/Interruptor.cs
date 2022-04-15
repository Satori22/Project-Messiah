using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interruptor : MonoBehaviour
{
    public GameObject obLigado;
    public GameObject obDesligado;

    public GameObject inteText;

    public GameObject obLuz;

    public AudioSource inteSom;

    public bool luzLigada;
    public bool luzDesligada;
    public bool noAlcance;
 
    // Start is called before the first frame update
    void Start()
    {
        noAlcance = false;
        luzLigada = false;
        luzDesligada = true;
        obLigado.SetActive(false);
        obDesligado.SetActive(true);
        obLuz.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "reach")
        {
            noAlcance = true;
            inteText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "reach")
        {
            noAlcance = false;
            inteText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
       if (luzDesligada && noAlcance && Input.GetButtonDown("Interagir"))
        {
            obLuz.SetActive(true);
            luzLigada = true;
            luzDesligada = false;
            obLigado.SetActive(true);
            obDesligado.SetActive(false);
            inteSom.Play();
        }

       else if (luzLigada && noAlcance && Input.GetButtonDown("Interagir"))
        {
            obLuz.SetActive(false);
            luzLigada = false;
            luzDesligada = true;
            obLigado.SetActive(false);
            obDesligado.SetActive(true);
            inteSom.Play();
        }
        
    }
}
