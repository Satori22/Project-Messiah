using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colocar_maca : MonoBehaviour
{
    public GameObject altar;
    public GameObject maca2;
    public GameObject invMaca;
    public GameObject colocarTxt;
    public GameObject semMacaTxt;

    public AudioSource somMaca2;

    public bool noAlcance;

    // Start is called before the first frame update
    void Start()
    {
        noAlcance = false;
        colocarTxt.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "reach")
        {
            colocarTxt.gameObject.SetActive(true);
            noAlcance = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "reach")
        {
            colocarTxt.gameObject.SetActive(false);
            noAlcance = false;
            semMacaTxt.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (noAlcance && invMaca.activeInHierarchy && !maca2.activeInHierarchy && Input.GetButtonDown("Interagir"))
        {
            maca2.gameObject.SetActive(true);
            invMaca.gameObject.SetActive(false);
            colocarTxt.gameObject.SetActive(false);
            altar.gameObject.SetActive(false);

            somMaca2.Play();
        }

        else if(noAlcance && !invMaca.activeInHierarchy && !maca2.activeInHierarchy && Input.GetButtonDown("Interagir"))
        {
            colocarTxt.gameObject.SetActive(false);
            semMacaTxt.gameObject.SetActive(true);
        }
        
    }
}
