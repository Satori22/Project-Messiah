using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pisca_Luz : MonoBehaviour
{

    public Light OBluz;

    //public AudioSource piscaSom;

    public float minTime;
    public float maxTime;
    public float timer;


    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        PiscaLuz();
    }

    void PiscaLuz()
    {
        if (timer > 0)
             timer -= Time.deltaTime;
        if (timer <= 0)
        {
            OBluz.enabled = !OBluz.enabled;
            timer = Random.Range(minTime, maxTime);
            //piscaSom.Play();
        }

    }
}
