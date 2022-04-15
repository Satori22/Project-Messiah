using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{

    public GameObject lanternaLigada;
    public GameObject lanternaDesligada;
    public GameObject OBlanterna;

    public GameObject chave;
    public GameObject OBchave;



    // Start is called before the first frame update
    void Start()
    {
        lanternaLigada.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OBlanterna.activeInHierarchy)
        {
            lanternaLigada.SetActive(true);
            lanternaDesligada.SetActive(false);
        }

        else
        {
            lanternaLigada.SetActive(false);
            lanternaDesligada.SetActive(true);
        }

        if (OBchave.activeInHierarchy)
        {
            chave.SetActive(true);
        }

        else
        {
            chave.SetActive(false);
        }


    }
}
