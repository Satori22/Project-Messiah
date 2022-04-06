using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegar_maca : MonoBehaviour
{

    public GameObject maca;
    public GameObject invMaca;
    public GameObject pegarTxt;
    public GameObject altar;

    public AudioSource somMaca;

    public bool noAlcance;



    // Start is called before the first frame update
    void Start()
    {
        noAlcance = false;
        pegarTxt.SetActive(false);
        invMaca.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "reach")
        {
            pegarTxt.gameObject.SetActive(true);
            noAlcance = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "reach")
        {
            pegarTxt.gameObject.SetActive(false);
            noAlcance = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(noAlcance && maca.activeInHierarchy && Input.GetButtonDown("Interagir"))
        {
            pegarTxt.gameObject.SetActive(false);
            invMaca.gameObject.SetActive(true);
            maca.gameObject.SetActive(false);
            somMaca.Play();
            altar.gameObject.SetActive(true);
        }
        

        
      
        
    }
}
