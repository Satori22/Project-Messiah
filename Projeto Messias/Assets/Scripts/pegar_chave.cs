using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegar_chave : MonoBehaviour
{

    public GameObject objChave;
    public GameObject objInv;
    public GameObject pegarTxt;
    public AudioSource somChave;

    public bool noAlcance;
    
    // Start is called before the first frame update
    void Start()
    {
        noAlcance = false;
        pegarTxt.SetActive(false);
        objInv.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "reach")
        {
            noAlcance = true;
            pegarTxt.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "reach")
        {
            noAlcance = false;
            pegarTxt.SetActive(false);
        }
    }



    // Update is called once per frame
    void Update()
    {
        if(noAlcance && Input.GetButtonDown("Interagir"))
        {
            objChave.SetActive(false);
            somChave.Play();
            pegarTxt.SetActive(false);
            objInv.SetActive(true);
        }
        
    }
}
