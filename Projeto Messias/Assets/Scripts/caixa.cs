using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caixa : MonoBehaviour
{

    public Animator objCaixa;
    public GameObject temChave;
    public GameObject interagirTxt;
    public GameObject semChaveTxt;
    public AudioSource somCaixa;

    public bool noAlcance;
    public bool aberto;

    // Start is called before the first frame update
    void Start()
    {
        noAlcance = false;
        aberto = false;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "reach")
        {
            noAlcance = true;
            interagirTxt.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "reach")
        {
            noAlcance = false;
            interagirTxt.SetActive(false);
            semChaveTxt.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (temChave.activeInHierarchy == true && noAlcance && Input.GetButtonDown("Interagir"))
        {
            temChave.SetActive(false);
            somCaixa.Play();
            objCaixa.SetBool("abrir", true);
            interagirTxt.SetActive(false);
            semChaveTxt.SetActive(false);
            aberto = true;
        }

        else if (temChave.activeInHierarchy == false && noAlcance && Input.GetButtonDown("Interagir"))
        {
            interagirTxt.SetActive(false);
            semChaveTxt.SetActive(true);
        }

        if (aberto)
        {
            objCaixa.GetComponent<BoxCollider>().enabled = false;
            objCaixa.GetComponent<caixa>().enabled = false;
        }
    }

}
