using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interruptor_desliga : MonoBehaviour
{

    public GameObject OBinte;
    public GameObject OBluz;

    public int desVezes = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (OBluz.activeInHierarchy && other.gameObject.tag == "Player")
        {
            Interruptor Interruptor = OBinte.GetComponent<Interruptor>();

            Interruptor.obLuz.SetActive(false);
            Interruptor.obLigado.SetActive(false);
            Interruptor.obDesligado.SetActive(true);
            Interruptor.inteSom.Play();
            Interruptor.luzDesligada = true;
            Interruptor.luzLigada = false;

            desVezes -= 1;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
        if (desVezes == 0)
        {
            Destroy(gameObject);
        }

    }
}
